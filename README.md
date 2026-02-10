# 🏎️ Telemetry Studio

Bu proje, **Racing Takımı** araçları ve Yamaha MT-07 ECU verilerini okumak için geliştirilmiş gerçek zamanlı bir telemetri yazılımıdır.

## 🚀 Özellikler
* **Gerçek Zamanlı Veri:** RPM, Hız, TPS, IAT, MAP, Timing ve Voltaj verileri.
* **Görsel Arayüz:** Sürücü ve mühendisler için optimize edilmiş "Race Cockpit" tasarımı.
* **Vites Algılama:** RPM ve Hız oranına göre anlık vites hesaplama algoritması.
* **Shift Light:** 9000 RPM üzerinde görsel vites uyarısı.
* **Bağlantı:** USB Serial (UART) üzerinden tak-çalıştır.
* * **Simülasyon Modu:** Donanım bağlı değilken test amaçlı sanal veri üretimi.

## 🛠️ Kullanılan Teknolojiler
* **Yazılım:** C# .NET Framework (Windows Forms)
* **Donanım:** Arduino (Uno/Nano) + MCP2515 CAN Bus Modülü
* **Protokol:** CAN-BUS (MCP2515 Modülü) & Serial Communication (UART)
* * **IDE:** Visual Studio 2022 & Arduino IDE

## 🔌 Kurulum
1. `Arduino_Code` klasöründeki kodu Arduino'ya yükleyin.
2. Aracı USB ile bilgisayara bağlayın.
3. `Software_App` klasöründeki projeyi Visual Studio ile açıp çalıştırın (veya .exe'yi kullanın).
4. COM portunu seçip **BAĞLAN** butonuna basın.

## 👨‍💻 Geliştirici
**Arda Hacımusalar** - *Bilgisayar Mühendisliği Öğrencisi @ Düzce Üniversitesi*
