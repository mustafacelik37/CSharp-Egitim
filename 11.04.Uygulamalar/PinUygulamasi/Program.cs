using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PÝN kodu kontrolü isteniyor.
            PÝN kodu 4 haneden oluþmak zorunda.
            Doðru PÝN kodu: 1453
            Eðer PÝN kodu yanlýþ ise yanlýþ uyarýsý verilsin.
            */

            //Console.WriteLine("Lütfen kelime giriniz: ");
            //string kelime = Console.ReadLine();
            //Console.WriteLine("Giridiðiniz {0} kelimesi {1} karakterden oluþmaktadýr.", kelime, kelime.Length);
            //Console.ReadLine();

            int pinKodu = 0; //Varsayýlan: 1453
            Console.WriteLine("Lütfen 4 haneli PIN kodunuzu giriniz: ");
            pinKodu = int.Parse(Console.ReadLine());

            //Gelen veri numerik bir veri mi ve 4 karakterli bir veri mi?
            if (Enumerable.Range(1000,9999).Contains(pinKodu))
            {
                //PIN kodu kontrolü yapýlýyor.
                if (pinKodu == 1453)
                {
                    Console.WriteLine("PIN kodunuz doðru!");
                }
                else
                {
                    Console.WriteLine("PIN kodunuz yanlýþ!");
                }
            }
            else
            {
                Console.WriteLine("PIN kodu 4 hane olmak zorundadýr.");
            }

            Console.ReadKey();

        }
    }
}
