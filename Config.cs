using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022400025
{
    internal class Config
    {
        // Properti untuk menyimpan konfigurasi
        public String lang { get; set; }
        public Transfer transfer { get; set; }
        public List<String> methods { get; set; }
        public Confirmation confirmation { get; set; }

        // Konstruktor untuk menginisialisasi konfigurasi default
        public Config()
        {
            this.lang = "en";
            this.transfer = new Transfer();
            this.methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
            this.confirmation = new Confirmation();
        }

        // Konstruktor untuk menginisialisasi konfigurasi dengan nilai tertentu
        public Config(String lang, Transfer transfer, List<String> methods, Confirmation confirmation)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirmation = confirmation;
        }
    }
}
