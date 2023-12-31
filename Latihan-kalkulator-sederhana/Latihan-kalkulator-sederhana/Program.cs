using System;

namespace Latihan_kalkulator_sederhana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // buatlah aplikasi kalkulator sederhana seperti di contoh
            // Masukkan angka pertama : 5
            // Masukkan angka kedua : 10
            // Masukkan operator (+,-,*,/) : *
            // Hasilnya 50

            char[] symbol = new char[4];
            symbol[0] = '+';
            symbol[1] = '-';
            symbol[2] = '*';
            symbol[3] = '/';

            //char sum = '+', reduction = '-', multiple = '*', division = '/';
            int pilihan;
            float angka1, angka2, hasil = 0;

            // Untuk memilih operator yang akan dipakai
            Console.WriteLine("Pilih Operator");
            Console.WriteLine("1. penjumlah (+)");
            Console.WriteLine("2. Pengurangan (-)");
            Console.WriteLine("3. Perkalian (*)");
            Console.WriteLine("4. Pembagian (/)");

            Console.Write("Masukkan pilihang anda [(+), (-), (*), (/)]: ");
            pilihan = Convert.ToChar(Console.ReadLine());

            // Untuk memilih operasi pada kalkulator menggunakan symbol matematika (+), (-), (*), (/).
            if (pilihan == symbol[0])
            {
                pilihan = 1;
            }
            else if (pilihan == symbol[1])
            {
                pilihan = 2;
            }
            else if (pilihan == symbol[2])
            {
                pilihan = 3;
            }
            else if (pilihan == symbol[3])
            {
                pilihan = 4;
            }

            if (pilihan < 5)
            {
                // Untuk memasukkan angka pertama
                Console.Write("Masukkan angka pertama : ");
                angka1 = int.Parse(Console.ReadLine());

                // Untuk memasukkan angka kedua
                Console.Write("Masukkan angka kedua : ");
                angka2 = int.Parse(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        hasil = angka1 + angka2;
                        break;
                    case 2:
                        hasil = angka1 - angka2;
                        break;
                    case 3:
                        hasil = angka1 * angka2;
                        break;
                    case 4:
                        if (angka2 != 0)
                        {
                            hasil = angka1 / angka2;
                        }
                        else
                        {
                            Console.WriteLine("Error : Pilihan tidak dapat melakukan pembagian oleh nol");
                        }
                        break;
                }

                Console.WriteLine($"Hasil : {hasil:N}");
            }
            else
            {
                Console.WriteLine("Error : Masukkan symbol operasi matematika yang telah disediakan!!!");
            }
            Console.ReadKey();

        }
    }
}