using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace latihan_atm_sederhana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buatlah aplikasi atm sederhana

            int pilihan = 0;
            float saldo, penarikan, setoran;

            Console.Write("Masukkan saldo akun anda : ");
            saldo = int.Parse(Console.ReadLine());

            Console.WriteLine("1. Periksa saldo");
            Console.WriteLine("2. Lakukan Setoran");
            Console.WriteLine("3. Lakukan Penarikan");

            Console.Write("Masukkan Pilihan anda : ");
            pilihan = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (pilihan)
            {
                case 1:
                    Console.WriteLine($"Saldo anda adalah : {saldo}");
                    break;
                case 2:
                    Console.Write("Masukkan jumlah yang akan disetor : ");
                    setoran = int.Parse(Console.ReadLine());
                    saldo += setoran;
                    Console.WriteLine($"Saldo akun anda yang telah diperbarui : {saldo}");
                    break;
                case 3:
                    Console.Write("Masukkan jumlah yang akan ditarik : ");
                    penarikan = int.Parse(Console.ReadLine());
                    if (penarikan > saldo)
                    {
                        Console.WriteLine("Saldo anda tidak cukup!!!");
                    } else
                    {
                        saldo -= penarikan;
                        Console.WriteLine($"Saldo akun anda yang telah diperbarui : {saldo}");
                    }
                    break;
            }

            Console.Read();
        }
    }
}
