using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConOrnekUygulamalar9b
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bir sayi giriniz");
            //int say1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("ikinci sayi giriniz");
            //int say2 = int.Parse(Console.ReadLine());

            //int toplam = say1 + say2;

            //Console.WriteLine("İşleminizin sonucu {0}", toplam);
            //Console.ReadKey();





            //string rol = "yonetici";

            //Console.WriteLine("rolünüzü giriniz");
            //string okunan = Console.ReadLine();

            //if (rol == okunan)
            //{
            //    Console.WriteLine("Hoşgeldin sahip");
            //}
            //else
            //{
            //    Console.WriteLine("tanımıyorum");
            //}
            //Console.ReadKey();


            //int toplam = 0;

            //for (int i = 1; i <= 40; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine("toplam " + toplam);
            //Console.ReadKey();



            //1 den 100 e kadar olan tek sayıların toplamını ekrana yazdıran programı yazınız



            //ekrana adınızı soyadınızı 100 defa yazdıran programı yazınız

            Console.WriteLine("adınızı soyadınızı giriniz");
            string gelenkelime = Console.ReadLine();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("hoşgeldin {0}", gelenkelime);

            }
            Console.ReadKey();



        }   
    }
}
