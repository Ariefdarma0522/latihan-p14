using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace latihan_p13_menghitung_luas_bangundatar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buatlah aplikasi untuk menghitung luas tanah / bangunan berbentuk
            Console.WriteLine("APLIKASI LUAS TANAH : ");    

            Console.WriteLine(" 1. Lingkaran");
            Console.WriteLine(" 2. Segitiga");
            Console.WriteLine(" 3. Trapesium");
            Console.WriteLine(" 4. Persegi panjang");
            Console.WriteLine(" 5. Jajargenjang");

            string nama;
            char ulang;
            double jari2, panjang, lebar, tinggi, hasil;
            int luasTanah;

            do
            {
                Console.Write("Pilih Nomor = ");
                luasTanah = int.Parse(Console.ReadLine());

                switch (luasTanah)
                {
                    case 1:
                        nama = "Lingkarang";
                        Console.WriteLine(nama);
                        Console.Write("Masukkan jari2 dari lingkarang = ");
                        jari2 = int.Parse(Console.ReadLine());
                        hasil = Math.PI * Math.Pow(jari2, 2); // Rumus lingkarang : phi x jari-jari^2
                        Console.Write($"Luas tanah lingkaran = {hasil} cm2");
                        break;
                    case 2:
                        nama = "segitiga";
                        Console.WriteLine(nama);
                        Console.Write("Masukkan alas segitiga : ");
                        panjang = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan tinggi dari segitiga : ");
                        tinggi = int.Parse(Console.ReadLine());
                        hasil = (1.0/2.0) * panjang * tinggi; // Rumus segitiga : 1/2 x alas x tinggi
                        Console.WriteLine($"Luas dari tanah segitiga : {hasil} cm2");
                        break;
                    case 3:
                        nama = "Trapesium";
                        Console.WriteLine(nama);
                        Console.Write("Masukkan panjang sisi \"A\" : ");
                        panjang = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan panjang sisi \"B\" : ");
                        lebar = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan tinggi dari trapesium : ");
                        tinggi = int.Parse(Console.ReadLine());
                        hasil = (1.0/2.0) * tinggi * (panjang * lebar); // Rumus 1/2 x tinggi (sisiA x sisiB)
                        Console.WriteLine($"Luas dari tanah trapesium : {hasil} cm2");
                        break;
                    case 4:
                        nama = "persegi panjang";
                        Console.WriteLine(nama);
                        Console.Write("Masukkan panjang : ");
                        panjang = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan lebar : ");
                        lebar = int.Parse(Console.ReadLine());
                        hasil = panjang * lebar; // Rumus persegi panjang : panjang x lebar
                        Console.WriteLine($"Luas tanah persegi panjang : {hasil} cm2");
                        break;
                    case 5:
                        nama = "jajar genjang";
                        Console.WriteLine(nama);
                        Console.Write("Masukkan panjang alas : ");
                        panjang = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan tinggi : ");
                        tinggi = int.Parse(Console.ReadLine());
                        hasil = panjang * tinggi; // panjang = alas jajar genjang , rumus jajar genjang alas x tinggi
                        Console.WriteLine($"Luas tanah jajar genjang : {hasil} cm2");
                        break;
                }
                Console.WriteLine("apakah anda ingin menghitung bentuk yang lain? [Y/T]");
                ulang = Convert.ToChar(Console.ReadLine());
            } while ((ulang == 'Y') || (ulang == 'y'));


            Console.Read();
        }
    }
}
