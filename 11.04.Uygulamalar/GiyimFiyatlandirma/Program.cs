using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiyimFiyatlandirma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            S: 25TL
            M: 30TL
            L: 35TL
            XL: 40TL
            
            || ÝF KONTROLÜNDE YADA ANLAMINA GELÝR.
            && ÝF KONTROLÜNDE VE ANLAMINA GELÝR.
            */

            string beden;
            Console.WriteLine("Lütfen beden bilgisi giriniz: (Örn: S yada M yada L yada XL)");
            beden = Console.ReadLine();
            beden = beden.ToUpper();

            /*Console.WriteLine("Lütfen kelime yada harf yazýnýz: ");
            string kelime = Console.ReadLine();
            Console.WriteLine("Yazdýðýnýz kelimenin küçük harfli hali: {0}",kelime.ToLower());
            Console.ReadLine();*/

            //Burada bana küçük harf gelme ihtimali 0
            if (beden == "S")
                Console.WriteLine("Ürün fiyatý: 25TL");
            else if (beden == "M")
                Console.WriteLine("Ürün fiyatý: 30TL");
            else if (beden == "L")
                Console.WriteLine("Ürün fiyatý: 35TL");
            else if (beden == "XL")
                Console.WriteLine("Ürün fiyatý: 40TL");
            else
                Console.WriteLine("Ýstenilen kriterlerde bir giriþ yapmadýnýz. Lütfen S - M - L - XL giriþlerinden birini yapýnýz.");

            Console.ReadKey();




        }
    }
}
