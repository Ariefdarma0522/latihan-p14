using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kalkulato_sederhana
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

            int pilihang;
            double angka1, angka2, hasil = 0.0;

            // Untuk memilih operator yang akan dipakai
            Console.WriteLine("Pilih Operator");
            Console.WriteLine("1. penjumlah (+)");
            Console.WriteLine("2. Pengurangan (-)");
            Console.WriteLine("3. Perkalian (*)");
            Console.WriteLine("4. Pembagian (/)");

            Console.WriteLine("Masukkan pilihang anda : [1-4]");
            pilihang = int.Parse(Console.ReadLine());

            // Untuk memasukkan angka pertama
            Console.WriteLine("Masukkan angka pertama : ");
            angka1 = Convert.ToDouble(Console.ReadLine());

            // Untuk memasukkan angka kedua
            Console.WriteLine("Masukkan angka kedua : ");
            angka2 = Convert.ToDouble(Console.ReadLine());

            switch (pilihang)
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
                    } else
                    {
                        Console.WriteLine("Error : Pilihan tidak dapat melakukan pembagian oleh nol");
                    }
                    break;
            }

            Console.WriteLine($"Hasil : {hasil}");
            Console.ReadKey();

        }
    }
}
