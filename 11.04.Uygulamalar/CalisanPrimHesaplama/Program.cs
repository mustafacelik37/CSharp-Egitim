using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanPrimHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir þirkette pazarlamacý olarak çalýþanlara yaptýklarý satýþa göre prim verilmektedir. Pazarlamacý, ne kadar çok satýþ yaparsa o kadar prim kazanacaktýr. Satýþlara göre prim yüzdeleri þöyledir;

            * 2.000 TL’den küçük satýþlar için prim yok. - 0
            * 2.000 TL ile 5.000 TL arasý (2.000 dâhil, 5.000 dâhil deðil) satýþýn %5’si prim,
            * 5000 TL ile 7.000 TL arasý (5.000 dâhil, 7.000 dâhil deðil) satýþýn %10’u prim,
            * 7.000 TL ve üstü %15 prim kazanmaktadýr.

            Buna göre girilen satýþ miktarýna göre pazarlamacýnýn ne kadar prim kazanacaðýný hesaplayan programý yazýnýz.
            */

            double satis;
            double prim = 0;
            string tarih = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
            int primOrani = 0;

            Console.WriteLine("Aylýk toplam satýþ tutarýnýzý giriniz: (Örn:2000)");
            satis = double.Parse(Console.ReadLine());

            if (satis < 2000) { 
                prim = 0;
                primOrani = 0;
            }
            else if (satis >= 2000 && satis < 5000) {
                primOrani = 5;
                prim = satis * primOrani / 100;
            }
            else if (satis >= 5000 && satis < 7000) {
                primOrani = 10;
                prim = satis * primOrani / 100;
            }
            else if (satis >= 7000) { 
                primOrani = 15;
                prim = satis * primOrani / 100;
            }
            else
                Console.WriteLine("Lütfen bilgilerinizi kontrol ediniz.");

            Console.WriteLine("{0} tarihi itibariyle bu ayki prim hakediþiniz: {1} TL Prim hakediþ oranýnýz: %{2}", tarih, prim, primOrani);
            Console.ReadKey();

        }
    }
}
