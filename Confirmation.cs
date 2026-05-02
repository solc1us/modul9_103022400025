using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022400025
{
    internal class Confirmation
    {
        // Properti untuk menyimpan pesan konfirmasi dalam bahasa Inggris dan Indonesia
        public String en { get; set; }
        public String id { get; set; }

        // Konstruktor untuk menginisialisasi pesan konfirmasi default
        public Confirmation()
        {
            this.en = "yes";
            this.id = "ya";
        }

        // Konstruktor untuk menginisialisasi pesan konfirmasi dengan nilai tertentu
        public Confirmation(String en, String id)
        {
            this.en = en;
            this.id = id;
        }
    }
}
