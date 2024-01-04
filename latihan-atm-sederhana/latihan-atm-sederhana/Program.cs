using System;

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
            Console.Write("\n");

            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Periksa saldo");
            Console.WriteLine("2. Lakukan Setoran");
            Console.WriteLine("3. Lakukan Penarikan");
            Console.Write('\n');

            Console.Write("Masukkan Pilihan anda : ");
            pilihan = int.Parse(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.WriteLine($"Saldo anda adalah {saldo:c}");
                    break;
                case 2:
                    Console.Write("Masukkan jumlah yang akan disetor : ");
                    setoran = int.Parse(Console.ReadLine());
                    saldo += setoran;
                    Console.WriteLine($"Anda melakukan setoran sebesar : {setoran:C2}");
                    Console.WriteLine("Saldo akun anda yang telah diperbarui : {0:C2}", saldo);
                    break;
                case 3:
                    Console.Write("Masukkan jumlah yang akan ditarik : ");
                    penarikan = int.Parse(Console.ReadLine());

                    // If, saya gunakan utk mengecek supaya penarikan tidak melebihi dari saldo, jika melebihi akan keluar alert "saldo tidak cukup".
                    if (saldo > penarikan)
                    {
                        saldo -= penarikan;
                        Console.WriteLine($"Anda telah menarik saldo dari akun anda sebesar : {penarikan:c}");
                        Console.WriteLine("Sisa saldo anda telah diperbarui : {0:C2}", saldo);
                    }
                    else
                    {
                        Console.WriteLine("Saldo anda tidak cukup!!!");
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}
