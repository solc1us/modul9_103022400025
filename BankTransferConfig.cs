using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul9_103022400025
{
    internal class BankTransferConfig
    {
        // Properti untuk menyimpan konfigurasi
        public Config config { get; set; }
        private string filePath = "bank_transfer_config.json";

        // Konstruktor untuk membaca konfigurasi dari file JSON
        public BankTransferConfig()
        {
            try
            {
                ReadConfigFile();

            }
            catch (Exception ex)
            {
                // Jika terjadi kesalahan saat membaca file, tampilkan pesan error dan buat konfigurasi default
                Console.WriteLine("Error reading config: " + ex.Message);
                Console.WriteLine("Setting default config.");
                SetDefault();
                WriteConfigFile();
            }
        }

        // Metode untuk membaca konfigurasi dari file JSON
        public void ReadConfigFile()
        {
            string jsonString = File.ReadAllText(filePath);
            config = JsonSerializer.Deserialize<Config>(jsonString);
        }

        // Metode untuk menulis konfigurasi ke file JSON
        public void WriteConfigFile()
        {
            string jsonString = JsonSerializer.Serialize(config);
            File.WriteAllText(filePath, jsonString);

        }

        // Metode untuk mengatur konfigurasi default
        public void SetDefault()
        {
            config = new Config(
                lang: "en",
                transfer: new Transfer(),
                methods: new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" },
                confirmation: new Confirmation()
            );
        }
    }
}
