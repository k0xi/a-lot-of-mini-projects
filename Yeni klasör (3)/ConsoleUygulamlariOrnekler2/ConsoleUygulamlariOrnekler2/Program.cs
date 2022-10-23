using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUygulamlariOrnekler2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            #region Girilen 4 basamaklı sayının basamaklarına ayıran programı yazınız

            int sayi, binler,yuzler, onlar, birler;

             Console.Write("Sayıyı Girin : ");
             sayi = Convert.ToInt32(Console.ReadLine());
             if (sayi >= 1000 & sayi <= 10000)
             {
             binler = sayi / 1000;
             sayi = sayi - (binler * 1000);

             yuzler = sayi / 100;
             sayi = sayi - (yuzler * 100);
             onlar = sayi / 10;
             sayi = sayi - (onlar * 10);
             birler = sayi;
             Console.WriteLine("Binler basamağı: {0}", binler);
             Console.WriteLine("Yüzler basamağı : {0}", yuzler);
             Console.WriteLine("Onlar basamağı : {0}", onlar);
             Console.WriteLine("Birler basamağı : {0}", birler);
             Console.ReadKey();

     
            

            
            }
            #endregion

            #region Girilen sayının asal olup olmadığını kontrol eden programı yazınız


            Console.WriteLine("Bir sayı giriniz");
            bool durum = false;

            int kontrol = 0;
            int sayi=Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0) 
                {
                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 1)
            {
                durum = false;
                Console.WriteLine("Sayı Asal değildir {0}", durum);
            }
            else
            {
                durum = true;
               Console.WriteLine("Sayı Asal sayıdır {0}", durum);
            }

            Console.ReadLine();

            #endregion




        }
    }
}
