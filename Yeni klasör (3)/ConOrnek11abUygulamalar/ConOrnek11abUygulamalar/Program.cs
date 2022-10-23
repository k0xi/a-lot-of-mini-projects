using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConOrnek11abUygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            //int toplam = 0;

            //for (int i = 0; i <= 40; i++)
            //{
            //    if (i%2!=0)
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine("0dan 40a kadar tek sayıların toplamı"+toplam);
            //Console.ReadLine();

            //Program 1 defa çalışacak
            //kullanıcıdan bir sayı alınacak ekrana okadar kendi ismini yazdıracaksın

            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());
            //do
            //{
            //    Console.WriteLine("Yavuz");
            //} while (sayi>0);
            //Console.ReadKey();


            //Kullanıcının rolü admin ise parola 123 ise hoşgeldin patron değilse yanlış yerdesin

            Console.WriteLine("Kullanıcı rolünüzü giriniz");
            string rol = Console.ReadLine();

            Console.WriteLine("Kullanıcı parolanızı giriniz");
            int pswd = Convert.ToInt32(Console.ReadLine());


            if (rol == "admin" && pswd == 123)
            {
                Console.WriteLine("Hoşgeldin Patron");

            }
            else
            {
                Console.WriteLine("Sen kimsin");
            }
            Console.ReadKey();
        }

    }
}
