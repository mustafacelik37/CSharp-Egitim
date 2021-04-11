using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir kargo fiyatý hesaplama modülü isteniyor.
            Algoritma detaylarý:
            0.1gr  ile 1000gr arasý 20TL (1000gr dahil olmasýn)
            1000gr ile 2000gr arasý 30TL
            2000gr ile 3000gr arasý 40TL
            3000gr üzeri de 100TL AMA 20kg'a kadar.        
            20.000gr üzeri de taþýnamaz.
            */

            double agirlik;
            Console.Write("Lütfen kargonunun aðýrlýðýný giriniz: (GR)");
            agirlik = double.Parse(Console.ReadLine());

            if (agirlik.ToString() == "") 
                Console.WriteLine("Kargo aðýrlýðý boþ olamaz!");

            if (agirlik == 0)
                Console.WriteLine("Kargo aðrýlýðý sýfýr (0) olamaz!");

            if (agirlik < 0.1)
                Console.WriteLine("Kargo aðýrlýðý minimum 0.1gr olmak zorundadýr!");
       
            if (agirlik >= 0.1 && agirlik < 1000)
                Console.WriteLine("Hesaplanan kargo tutarý: 20TL");

            if (agirlik >= 1000 && agirlik < 2000)
                Console.WriteLine("Hesaplanan kargo tutarý: 30TL");

            if (agirlik >= 2000 && agirlik < 3000)
                Console.WriteLine("Hesaplanan kargo tutarý: 40TL");

            if (agirlik >= 3000 && agirlik<20000)
                Console.WriteLine("Hesaplanan kargo tutarý: 100TL");

            if (agirlik > 20000)
                Console.WriteLine("Sisteme 20kg'dan fazla aðýrlýða sahip kargo kabul edilememektedir.");


            Console.ReadKey();

        }
    }
}
