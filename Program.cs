// See https://aka.ms/new-console-template for more information
using System;

using Modul9_103022400025;

// Inisialisasi BankTransferConfig
BankTransferConfig bankTransferConfig = new BankTransferConfig();

// Baca data dari file JSON
bankTransferConfig.ReadConfigFile();

// Tampilkan pesan untuk memasukkan jumlah uang yang akan di-transfer
if (bankTransferConfig.config.lang == "en")
{
    Console.WriteLine("Please insert the amount of money to transfer:");
}
else if (bankTransferConfig.config.lang == "id")
{
    Console.WriteLine("Masukkan jumlah uang yang akan di-transfer");    
}

// Baca input jumlah uang yang akan di-transfer
double transferAmount = double.Parse(Console.ReadLine());

// Hitung biaya transfer berdasarkan threshold
double transferFee = transferAmount < bankTransferConfig.config.transfer.threshold 
    ? bankTransferConfig.config.transfer.low_fee : bankTransferConfig.config.transfer.high_fee;

// Hitung total biaya transfer
double totalAmount = transferAmount + transferFee;

// Tampilkan biaya transfer, total biaya, dan pilihan metode transfer
if (bankTransferConfig.config.lang == "en")
{
    Console.WriteLine("Transfer fee = " + transferFee);
    Console.WriteLine("Total amount = " + totalAmount);
    Console.WriteLine("Select transfer method: ");
}
else if (bankTransferConfig.config.lang == "id")
{
    Console.WriteLine("Biaya transfer = " + transferFee);
    Console.WriteLine("Total biaya = " + totalAmount);
    Console.WriteLine("Pilih metode transfer: ");
}

// Tampilkan pilihan metode transfer
for (int i = 0; i < bankTransferConfig.config.methods.Count; i++)
{
     Console.WriteLine((i + 1) + ". " + bankTransferConfig.config.methods[i]);
}

// Baca input pilihan metode transfer
int methodChoice = int.Parse(Console.ReadLine()) - 1;

// Tampilkan pesan konfirmasi berdasarkan bahasa yang dipilih
if (bankTransferConfig.config.lang == "en")
{
    Console.WriteLine("Please type '" + bankTransferConfig.config.confirmation.en 
        + "' to confirm the transaction: ");
}
else if (bankTransferConfig.config.lang == "id")
{
    Console.WriteLine("Ketik '" + bankTransferConfig.config.confirmation.id 
        + "' untuk mengkonfirmasi transaksi: ");
}

// Baca input konfirmasi
String confirmationInput = Console.ReadLine();

confirmationInput = confirmationInput.Trim().ToLower();

// Cek konfirmasi dan tampilkan hasil transfer berdasarkan bahasa yang dipilih
if (bankTransferConfig.config.lang == "en")
{
    if (confirmationInput.Equals(bankTransferConfig.config.confirmation.en))
    {
        Console.WriteLine("The transfer is completed using " + bankTransferConfig.config.methods[methodChoice]);
    }
}
else if (bankTransferConfig.config.lang == "id")
{
    if (confirmationInput.Equals(bankTransferConfig.config.confirmation.id))
    {
        Console.WriteLine("Transfer berhasil menggunakan " + bankTransferConfig.config.methods[methodChoice]);
    }
}
else
{
    if (bankTransferConfig.config.lang == "en")
    {
        Console.WriteLine("Transfer is cancelled.");

    }
    else if (bankTransferConfig.config.lang == "id")
    {
        Console.WriteLine("Transfer dibatalkan.");
    }
}