using System;

namespace latihan_persiapan_ujian1_volume_balok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buatlah aplikasi untuk menghitung Volume / isi

            Console.WriteLine("Pilih bidang 3D berikut : ");
            Console.WriteLine("1. Balok");
            Console.WriteLine("2. Kubus");
            Console.WriteLine("3. Tabung");
            Console.WriteLine("4. Bola");
            Console.WriteLine("5. Kerucut");

            string nama = null;
            char ulang;
            double hasil;
            float ukuran, panjang, lebar, jari2, tinggi;

            do
            {
                Console.Write("Pilih bangun 3D yang akan dihitung: ");
                ukuran = int.Parse(Console.ReadLine());


                switch (ukuran) // Untuk memilih bagung ruang apa yang akan dihitung
                {
                    case 1:
                        // Untuk menampilkan nama dari bangun ruang
                        nama = "Balok";
                        Console.WriteLine(nama);
                        // Untuk memasukkan nilai panjang
                        Console.Write("Masukkan panjang : ");
                        panjang = int.Parse(Console.ReadLine());
                        // Untuk memasukkan nilai lebar
                        Console.Write("Masukkan Lebar : ");
                        lebar = int.Parse(Console.ReadLine());
                        // Untuk memasukkan nilai tinggi
                        Console.Write("Masukkan Tinggi : ");
                        tinggi = int.Parse(Console.ReadLine());
                        // Untuk mencari hasil & manampilkan hasil dari volume
                        hasil = panjang * lebar * tinggi; // Rumus balok : panjang x lebar x tinggi
                        Console.WriteLine($"Volume Balok = {hasil:N1} cm3");
                        break;
                    case 2:
                        // Untuk menampilkan nama dari bangun ruang
                        nama = "Kubus";
                        Console.WriteLine(nama);
                        // Untuk memasukkan nilai sisi dari kubus
                        Console.Write("masukkan ukuran sisinya : ");
                        panjang = int.Parse(Console.ReadLine());
                        // Untuk mencari hasil & menampilkan hasil dari kubus
                        hasil = Math.Pow(panjang, 3); // Rumus kubus : sisi^3
                        Console.WriteLine($"Volume Kubus = {hasil:N1} cm3");
                        break;
                    case 3:
                        // Untuk menampilkan nama dari bangun ruang
                        nama = "Tabung";
                        Console.WriteLine(nama);
                        // Untuk memasukkan nilai jari-jari dari tabung
                        Console.Write("Masukkan Jari-jari dari tabung : ");
                        jari2 = int.Parse(Console.ReadLine());
                        // Untuk memasukkan nalai tinggi dari tabung
                        Console.Write("Masukkan tinggi dari kerucut : ");
                        tinggi = int.Parse(Console.ReadLine());
                        // Untuk mencari hasil & menampilkan hasil
                        hasil = Math.PI * Math.Pow(jari2, 2) * tinggi; // Rumus Tabung : phi x jari-jari^2 x tinggi
                        Console.WriteLine($"Volume dari Tabung = {hasil:N1} cm3");
                        break;
                    case 4:
                        // Untuk menampilkan nama dari bangun ruang
                        nama = "Bola";
                        Console.WriteLine(nama);
                        // Untuk memasukkan nilai dari jari-jari bola
                        Console.Write("Masukkan Jari-jari dari bola : ");
                        jari2 = int.Parse(Console.ReadLine());
                        // Untuk mencari hasil & menampilkan hasil dari bangun ruang bola
                        hasil = (4.0 / 3.0) * Math.PI * Math.Pow(jari2, 3); // Rumus Bola : 4/3 x phi x jari-jari^3
                        Console.WriteLine($"Volume dari bola = {hasil:N1} cm3");
                        break;
                    case 5:
                        // Untuk menampilkan nama dari bangun ruang
                        nama = "Kerucut";
                        Console.WriteLine(nama);
                        // Untuk memasukkan nilai jari2 dari kerucut
                        Console.Write("masukkan jari-jari dari kerucut : ");
                        jari2 = int.Parse(Console.ReadLine());
                        // Untuk memasukkan nilai tinggi dari kerucut
                        Console.Write("Masukkan tinggi dari kerucut : ");
                        tinggi = int.Parse(Console.ReadLine());
                        // Untuk mencari hasil dari kerucut & menampilkan hasil
                        hasil = (1.0 / 3.0) * Math.PI * Math.Pow(jari2, 2) * tinggi; // Rumus kerucut : 1/3 x phi x jari-jari^2 x tinggi
                        Console.WriteLine($"Volume dari kerucut = {hasil:N1} cm3");
                        break;

                }
                Console.WriteLine("Apakah anda ingin megulangi lagi ? [Y/T]");
                ulang = Convert.ToChar(Console.ReadLine());
            } while ((ulang == 'Y') || (ulang == 'y'));

            Console.ReadKey();
        }
    }
}
