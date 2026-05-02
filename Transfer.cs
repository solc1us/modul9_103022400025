using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022400025
{
    internal class Transfer
    {
        // Properti untuk menyimpan values threshold, low_fee, dan high_fee
        public double threshold { get; set; }
        public double low_fee { get; set; }
        public double high_fee { get; set; }

        // Konstruktor untuk menginisialisasi values default
        public Transfer()
        {
            this.threshold = 25000000.0;
            this.low_fee = 6500.0;
            this.high_fee = 15000.0;
        }

        // Konstruktor untuk menginisialisasi values dengan nilai tertentu
        public Transfer(double threshold, double low_fee, double high_fee)
        {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }

    }
}
