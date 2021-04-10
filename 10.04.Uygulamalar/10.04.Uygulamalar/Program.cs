using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _10._04.Uygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir bankacılık uygulamasının yaklaşık birikim hesaplamasını yaptırmak istiyoruz.
            --------
            Euro kur bilgisine ihtiyacım var.
            Dolar kur bilgisine ihtiyacım var.
            Elimdeki dolar miktarina ihtiyacım var.
            Elimdeki euro miktarına ihtiyacım var.
            Elimdeki TL miktarına ihtiyacım var.
            */
            
                        

            double miktarEUR, miktarUSD, miktarTL;
            double euroKur, dolarKur;
            double toplam;

            //Kurları alalım.
            Console.Write("Lütfen güncel Dolar(USD) kurunu giriniz: ");
            dolarKur = double.Parse(Console.ReadLine());

            Console.Write("Lütfen güncel Euro (EUR) kurunu giriniz: ");
            euroKur = double.Parse(Console.ReadLine());

            //TL bakiyesini alalım.
            Console.Write("Lütfen Türk lirası (TL) bakiyenizi giriniz: ");
            miktarTL = double.Parse(Console.ReadLine());

            //Dolar bakiyesini alalım.
            Console.Write("Lütfen Dolar (USD) bakiyenizi giriniz: ");
            miktarUSD = double.Parse(Console.ReadLine());

            //Euro bakiyesini alalım.
            Console.Write("Lütfen Euro (EUR) bakiyenizi giriniz: ");
            miktarEUR = double.Parse(Console.ReadLine());

            toplam = (miktarEUR * euroKur) + (miktarUSD * dolarKur) + miktarTL;
            Console.WriteLine("{0} TL kadar toplam bakiyeniz mevcut.",toplam);
            Console.ReadLine();






        }
    }
}
