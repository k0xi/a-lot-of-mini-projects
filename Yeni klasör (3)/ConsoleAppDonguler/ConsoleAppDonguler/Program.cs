using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppDonguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //Rastgele Tutulan sayı tahmin etme Oyunu

            /*
             
             Do while döngüsü program çalıştığı anda bir kere mutlaka çalışır
             
             */

            //Random rnd = new Random();
            //int tutulansayi = rnd.Next(1, 100);

            //int tahmin;

            //do
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    tahmin = Convert.ToInt32(Console.ReadLine());
            //    if (tahmin < tutulansayi)
            //        Console.WriteLine("daha büyük bir değer giriniz");
            //    else if(tahmin>tutulansayi)
            //        Console.WriteLine("daha küçük bir değer giriniz");
            //    else
            //        Console.WriteLine("brovo bildin");
            //} while (tahmin != tutulansayi);

            // While döngüsü 


            /*
             While döngüsünde koşul sağlandıkça dönmeye devam eder
             
             */
            // Ekrana adınızı 100 defa yazdırın

            //int sayac = 0;


            //while (sayac <=100 )
            //{
            //    sayac++;


            //    Thread.Sleep(1000);// Ekrana 1 saniye aralıklar ile yazsın 
            //    Console.WriteLine("Adınız Soyadınız" + sayac);
            //}

            //int sonuc;

            //for (int i = 1; i <= 9; i++)
            //{

            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.WriteLine("{0}x{1}={2}", i, j, i * j);
            //    }
            //    Console.WriteLine("-----------------------------");
            //}
            //Console.WriteLine("Çarpım Tablosu");
            //Console.ReadLine();



            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.WriteLine("{0}x{1}={2}",i,j,i*j);
            //    }
            //    Console.WriteLine("----------------------");
            //}
            //Console.ReadKey();

            //Random rnd = new Random();
            //int tutulansayi= rnd.Next(1, 100);
            //int tahmin;
            //do
            //{
            //    Console.WriteLine("Sayı tahmin et");
            //   tahmin =Convert.ToInt32( Console.ReadLine());
            //    if(tahmin>tutulansayi)
            //        Console.WriteLine("Daha küçük tahmin et ");
            //    else if(tahmin<tutulansayi)
            //        Console.WriteLine("Daha büyük tahmin et ");
            //    else
            //        Console.WriteLine("Helal olsun bildin");

            //} while (tutulansayi!=tahmin);

            int sayac = 0;
            while (sayac<100)
            {
                sayac++;
                Thread.Sleep(1000);
                Console.WriteLine("Sinan Arslan");
            }
            Console.ReadKey();

        }
    }
}
