using System;
using System.Text.Json;
using modul8_103022300110;

class Program 
{
    public static void Main(string[] args)
    {
        BankTransfer config = new BankTransfer();
        string confirm;
        int amount = 0;
        string transferMethod;

        if (config.config.lang == "en" )
        {
            Console.WriteLine("Please insert the amount of money to transfer:");
            amount = int.Parse(Console.ReadLine());

            if (amount <= config.config.transfer.threshold)
            {
                Console.WriteLine($"The Transfer Fee is : {config.config.transfer.low_fee + amount}");
            }
            else
            {
                Console.WriteLine($"The Transfer Fee is : {config.config.transfer.high_fee + amount}");
            }

            Console.WriteLine("Select transfer method:");

            for (int i = 0; i < config.config.methods.Count; i++)
            {
                Console.WriteLine($"{i+1}, {config.config.methods[i]}");
            }

            transferMethod = Console.ReadLine();

            Console.WriteLine($"Please type {config.config.confirmation.en} to confirm the transaction:");
            confirm = Console.ReadLine();

            if( confirm == "yes")
            {
                Console.WriteLine(" The transfer is completed");
            }
            else
            {
                Console.WriteLine(" Transfer is cancelled");
            }

        } else if (config.config.lang == "id")
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer:");
            amount = int.Parse(Console.ReadLine());

            if (amount <= config.config.transfer.threshold)
            {
                Console.WriteLine($"Biaya Transfernya adalah : {config.config.transfer.low_fee + amount}");
            }
            else
            {
                Console.WriteLine($"Biaya Transfernya adalah  : {config.config.transfer.high_fee + amount}");
            }

            Console.WriteLine("Pilih metode transfer:");

            for (int i = 0; i < config.config.methods.Count; i++)
            {
                Console.WriteLine($"{i + 1}, {config.config.methods[i]}");
            }

            transferMethod = Console.ReadLine();

            Console.WriteLine($" Ketik {config.config.confirmation.id}  untuk mengkonfirmasi transaksi:");
            confirm = Console.ReadLine();

            if (confirm == "yes")
            {
                Console.WriteLine("  Proses transfer berhasil");
            }
            else
            {
                Console.WriteLine("  Transfer dibatalkan");
            }
        }

    }

}