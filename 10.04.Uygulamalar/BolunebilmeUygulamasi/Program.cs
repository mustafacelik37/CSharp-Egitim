using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolunebilmeUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanýcýdan bir sayý alalým.
            Bu sayý 1'den 9'a kadar hangi sayýlara bölünebilir?
            Program bize bunun yanýtýný versin.
            */

            int sayi;
            string egitim = "C# Eðitimi";
            Console.Write("Lütfen bir sayý giriniz: ");
            sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Girmiþ olduðunuz sayý: {0}",sayi);

            if (sayi % 2 == 0)
                Console.WriteLine("{0} sayýsý 2'ye bölünebilir. Eðitim: {1}", sayi, egitim);
            else
                Console.WriteLine("{0} sayýsý 2'ye bölünemez. Eðitim: {1}", sayi, egitim);

            if (sayi % 3 == 0)
                Console.WriteLine("{0} sayýsý 3'e bölünebilir. Eðitim: {1}", sayi, egitim);
            else
                Console.WriteLine("{0} sayýsý 3'e bölünemez. Eðitim: {1}", sayi,egitim);

            Console.ReadLine();



        }
    }
}
