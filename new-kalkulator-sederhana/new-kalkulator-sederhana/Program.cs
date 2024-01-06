using System;

namespace new_kalkulator_sederhana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buatlah aplikasi kalkulator sederhana seperti di bawah ini
            // Masukkan angka pertama : 5
            // Masukkan angka kedua   : 10
            // Masukkan operator (+,-,*,/): *
            // Hasilnya adalah : 50

            float angka1, angka2, hasil = 0;

            // Untuk memasukkan angka ke 1
            Console.Write("Masukkan angka pertama : ");
            angka1 = int.Parse(Console.ReadLine());

            // Untuk memasukkan angka ke 2
            Console.Write("Masukkan angka kedua : ");
            angka2 = int.Parse(Console.ReadLine());

            // Untuk memilih operasi matematika pada kalkulator
            Console.Write("Masukkan operator(+,-,*,/) : ");
            int pilihan = Convert.ToChar(Console.ReadLine());

            switch (pilihan)
            {
                case '+':
                    hasil = angka1 + angka2;
                    Console.Write($"Hasil : {hasil:N}");
                    break;
                case '-':
                    hasil = angka1 - angka2;
                    Console.Write($"Hasil : {hasil:N}");
                    break;
                case '*':
                    hasil = angka1 * angka2;
                    Console.Write($"Hasil : {hasil:N}");
                    break;
                case '/':
                    if (angka2 != 0)
                    {
                        hasil = angka1 / angka2;
                        Console.Write($"Hasil : {hasil:N}");
                    }
                    else
                    {
                        Console.WriteLine("Error : angka tidak dapat dibagi dengan 0 (nol)");
                    }
                    break;
                default:
                    Console.WriteLine("Error : Masukkan Symbol operasi yang ada!!!");
                    break;

            }

            Console.ReadKey();
        }
    }
}
