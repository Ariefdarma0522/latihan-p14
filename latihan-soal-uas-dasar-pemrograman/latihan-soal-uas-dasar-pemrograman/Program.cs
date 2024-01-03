using System;

namespace latihan_soal_uas_dasar_pemrograman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Bagaimana cara mendeklarasikan sebuah array bernama "angka" yang akan menampun 10 elemen integer?
            // 2. Bagaimana cara mengisi elemen-elemen dari array "angka" di atas dengan nila 1,2,3,4,5,6,7,,8,9,10 secara berurutan?
            // 3. Bagaimana cara menampilakn semua elemen array "angka" yang telah diisi di atas?
            // 4. Bagaimana cara menghitung total dari semua elemen dari array "angka" yang telah diisi di atas?
            // Bagaimana cara mencari elemen dengan nilai tertinggi dari array "angka" yang telah diisi di atas?

            // jawaban no 1
            int[] angka = new int[10];
            //jawaban no 2
            angka[0] = 1;
            angka[1] = 2;
            angka[2] = 3;
            angka[3] = 4;
            angka[4] = 5;
            angka[5] = 6;
            angka[6] = 7;
            angka[7] = 8;
            angka[8] = 9;
            angka[9] = 10;

            // jawaban no 3
            foreach (int elemen in angka)
            {
                Console.WriteLine(elemen);
            }

            // jawaban no 4
            int total = 0;
            foreach (int a in angka)
            {
                total += a;
            }
            Console.WriteLine("Total : " + total);

            // Jawaban no 5
            int tertinggi = angka[0];
            foreach (int elemen in angka)
            {
                if (elemen > tertinggi)
                {
                    tertinggi = elemen;
                }
            }
            Console.WriteLine("Tertinggi : " + tertinggi);

            Console.ReadKey();
        }
    }
}
