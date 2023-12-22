using System;
using System.Globalization;

namespace number_formating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10000, percent1 = 1;

            // Number format for currency / mata uang
            Console.WriteLine("mata uang");
            Console.WriteLine(string.Format(new CultureInfo("en-US"), "US dolar : {0:C}", number));
            Console.WriteLine(string.Format(new CultureInfo("id-ID"), "INDONESIA Rupiah : {0:C}", number));
            Console.WriteLine(string.Format(new CultureInfo("ja-JP"), "JEPAN Yen : {0:C}", number));
            Console.WriteLine("\n");

            double number2 = 34.12;

            // Number format, angka desimal & percent (%)
            Console.WriteLine("angka berkoma");
            Console.WriteLine("Angka berkoma Float: {0:f}", number2);
            // percent
            Console.WriteLine($"angka percent : {percent1:p}");



            Console.ReadLine();

        }
    }
}
