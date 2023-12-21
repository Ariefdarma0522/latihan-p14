using System;

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


            // Untuk memilih operator yang akan dipakai
            Console.WriteLine("Pilih Operator");
            Console.WriteLine("1. penjumlah (+)");
            Console.WriteLine("2. Pengurangan (-)");
            Console.WriteLine("3. Perkalian (*)");
            Console.WriteLine("4. Pembagian (/)");

            Console.WriteLine("Masukkan pilihang anda : [1-4]");
            pilihang = Convert.ToInt32(Console.ReadLine());

            // Untuk memasukkan angka pertama
            Console.WriteLine("Masukkan angka pertama : ");
            double angka1 = Convert.ToDouble(Console.ReadLine());

            // Untuk memasukkan angka kedua
            Console.WriteLine("Masukkan angka kedua : ");
            double angka2 = Convert.ToDouble(Console.ReadLine());

            double hasil = 0.0;

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
                    }
                    else
                    {
                        Console.WriteLine("Error : Pilihan tidak dapat melakukan pembagian oleh nol");
                    }
                    break;
            }

            Console.WriteLine($"Hasil : {hasil:N}");
            Console.ReadKey();

        }
    }
}
