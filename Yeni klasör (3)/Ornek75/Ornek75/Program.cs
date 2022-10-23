using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek75
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //int tutulansayi=rnd.Next(1, 100);
            //int tahmin;

            //do
            //{
            //    Console.WriteLine("Bir sayı tahmin et");
            //    tahmin =int.Parse(Console.ReadLine());
            //    if(tahmin>tutulansayi)
            //        Console.WriteLine("Daha Küçük bir sayı tahmin et");
            //    else if(tahmin<tutulansayi)
            //        Console.WriteLine("Daha büyük bir sayı tahmin et");
            //    else
            //        Console.WriteLine("Bildiniz");

            //} while (tahmin!=tutulansayi);

            //int sayac =0;
            //while (sayac<100)
            //{
            //    sayac++;
            //    Console.WriteLine("Sinan Arslan"+sayac);
            //}
            //Console.ReadKey();

            //1 den 40 kadar olan çift sayıların toplamını ekrana yazdıran 
            //programı yazınız
            int toplam=0;
            for (int i = 1; i <= 40; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                    Console.WriteLine("1 den 40 kadar olan çift sayıların toplamı{0}",toplam);
                }
              
            }
            Console.ReadKey();
        }
    }
}
