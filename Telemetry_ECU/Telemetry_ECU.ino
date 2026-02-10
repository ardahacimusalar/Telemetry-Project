#include <SPI.h>
#include <mcp_can.h>

/*
 * Project: MT-07 Advanced Telemetry Unit
 * Features: RPM, TPS, Speed, IAT, MAP, Timing, Battery, Calculated Gear
 */

const int SPI_CS_PIN = 9; // Eğer Arduino Uno kullanılıyorsa CS pini genelde 9 veya 10'dur. Modüle göre değişebilir.
MCP_CAN CAN(SPI_CS_PIN);

// --- STANDART OBD-II PID ADRESLERİ ---
#define PID_ENGINE_LOAD     0x04
#define PID_COOLANT_TEMP    0x05
#define PID_MAP             0x0B  // Manifold Basıncı
#define PID_ENGINE_RPM      0x0C
#define PID_VEHICLE_SPEED   0x0D
#define PID_TIMING_ADVANCE  0x0E  // Ateşleme Avansı
#define PID_INTAKE_TEMP     0x0F  // IAT
#define PID_THROTTLE_POS    0x11  // TPS
#define PID_MODULE_VOLTAGE  0x42  // ECU Voltajı

#define CAN_ID_PID 0x7DF // Sorgu ID'si

// Değişkenler
int rpm = 0;
int speed = 0;
int gear = 0; // 0: Boş, 1-6: Vitesler

void setup() {
    Serial.begin(115200);
    // Eğer modülün üzerindeki metal parçada 16.000 yazıyorsa MCP_8MHZ kısmı MCP_16MHZ yapılmalı
    if (CAN.begin(MCP_ANY, CAN_500KBPS, MCP_8MHZ) == CAN_OK) {  
        Serial.println("CAN Baglantisi OK!");
    }
    else {
        Serial.println("CAN Hatasi! Kablolari kontrol et.");
        while (1);
    }
    CAN.setMode(MCP_NORMAL);
}

void loop() {
    // Tüm sensörleri sırayla oku
    rpm = getPID(PID_ENGINE_RPM);
    speed = getPID(PID_VEHICLE_SPEED);
    int tps = getPID(PID_THROTTLE_POS);
    int iat = getPID(PID_INTAKE_TEMP);
    int mapVal = getPID(PID_MAP);
    int timing = getPID(PID_TIMING_ADVANCE);
    float voltage = getPID(PID_MODULE_VOLTAGE) / 1000.0; // Genelde mV döner

    // --- VİTES HESAPLAMA ALGORİTMASI ---
    gear = calculateGear(rpm, speed);

    // Format: RPM,Speed,Gear,TPS,IAT,MAP,Timing,Voltage
    Serial.print(rpm); Serial.print(",");
    Serial.print(speed); Serial.print(",");
    Serial.print(gear); Serial.print(",");
    Serial.print(tps); Serial.print(",");
    Serial.print(iat); Serial.print(",");
    Serial.print(mapVal); Serial.print(",");
    Serial.print(timing); Serial.print(",");
    Serial.println(voltage);
}

// PID İsteme ve Okuma Fonksiyonu
int getPID(unsigned char pid) {
    unsigned char tmp[8] = { 0x02, 0x01, pid, 0, 0, 0, 0, 0 };
    CAN.sendMsgBuf(CAN_ID_PID, 0, 8, tmp);

    unsigned long rxId;
    unsigned char len = 0;
    unsigned char rxBuf[8];

    // Cevap bekleme (Basit timeout)
    unsigned long timeout = millis();
    while (millis() - timeout < 10) { // 50ms bekle
        if (CAN_MSGAVAIL == CAN.checkReceive()) {
            CAN.readMsgBuf(&rxId, &len, rxBuf);
            if (rxBuf[1] == 0x41 && rxBuf[2] == pid) {
                // Formüller (Standart OBD-II Matematiği)
                switch (pid) {
                case PID_ENGINE_RPM: return ((rxBuf[3] * 256) + rxBuf[4]) / 4;
                case PID_VEHICLE_SPEED: return rxBuf[3];
                case PID_THROTTLE_POS: return (rxBuf[3] * 100) / 255;
                case PID_INTAKE_TEMP: return rxBuf[3] - 40;
                case PID_COOLANT_TEMP: return rxBuf[3] - 40;
                case PID_MAP: return rxBuf[3]; // kPa cinsinden
                case PID_TIMING_ADVANCE: return (rxBuf[3] / 2) - 64; // Derece cinsinden
                case PID_MODULE_VOLTAGE: return ((rxBuf[3] * 256) + rxBuf[4]);
                }
            }
        }
    }
    return 0; // Hata veya zaman aşımı
}

// Vites Hesaplama (Ratio Yöntemi)
int calculateGear(int r, int s) {
    if (s == 0 || r == 0) return 0; // Duruyor

    float ratio = (float)r / (float)s;

    // NOT: Bu değerleri motoru sürüp Serial Monitor'den log alarak bulunacak.
    // Aşağıdakiler örnektir!
    if (ratio > 140 && ratio < 160) return 1;
    if (ratio > 100 && ratio < 120) return 2;
    if (ratio > 80 && ratio < 95) return 3;
    if (ratio > 65 && ratio < 75) return 4;
    if (ratio > 50 && ratio < 60) return 5;
    if (ratio > 40 && ratio < 48) return 6;

    return 0; // Bilinmeyen vites
}
