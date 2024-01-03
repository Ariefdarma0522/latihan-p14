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

            // Menginisialisasi variabel
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

            // If, saya gunakan utk mengubah kembali variabel "Pilihan" dari 'char' menjadi 'int' kembali. Untuk menjalankan fungsi switch 
            if (pilihan == '+')
            {
                pilihan = 1;
            }
            else if (pilihan == '-')
            {
                pilihan = 2;
            }
            else if (pilihan == '*')
            {
                pilihan = 3;
            }
            else if (pilihan == '/')
            {
                pilihan = 4;
            }

            // If, saya gunakan utk menghindari error ketika code dijalankan tetapi tidak menggunakan symbol yang ada, yang dimana jika code ttp dijalan console ttp akan menampilkan hasil walaupun hasil nya adalah 0 
            if (pilihan < 5)
            {
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
                            Console.WriteLine("Error : angka tidak dapat dibagi dengan 0 (nol)");
                        }
                        break;
                }
                Console.Write($"Hasil : {hasil:N}");
            }
            else
            {
                Console.WriteLine("Error : Masukkan symbol operasi yang ada!!!");
            }

            Console.ReadKey();
        }
    }
}
