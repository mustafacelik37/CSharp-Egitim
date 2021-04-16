using System;

namespace ödev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*klavyeden 2 adet sayı girişi yapalım.
             sadece sayı girişi kabul edelim.
            1 ile 100 arasında giriş yapılabilsin.1 ve 100 dahil.
            iki sayının da toplama işelmi yapılabilir durumda olsun.
            */

            int sayı1, sayı2, t = 0;
            while (true)
{
                Console.WriteLine("1. Sayiyi giriniz: ");
              sayı1= Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2. Sayiyi giriniz: ");
                sayı2 =Convert.ToInt32( Console.ReadLine());
                if(sayı1< 0 || sayı1 > 100 || sayı2 < 0 || sayı2 > 100)
                {
                    Console.WriteLine("girdiğiniz sayı 0 ile 100 arasında olmalıdır.");
                
}
                else
{
                    t = sayı1 + sayı2;
                    break;

                }
            }
            Console.WriteLine(t);
            Console.ReadKey();













        }
    }
}

      
                



               

            

        
    

