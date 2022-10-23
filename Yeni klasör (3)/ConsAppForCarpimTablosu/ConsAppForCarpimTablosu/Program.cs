using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppForCarpimTablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Çarpım Tablosu Yapımı

            //Console.WriteLine("Çarpım Tablosu Yapımı");
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 0; j <= 9; j++)
            //    {
            //        Console.WriteLine("{0}x{1}={2}", i, j, i * j);
            //    }
            //    Console.WriteLine("------------------------");
            //}
            //Console.ReadLine();

            #endregion

            #region Faktoriyel Hesaplama

            //Console.WriteLine("Faktoriyeli hesaplanacak sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = sayi; i > 1; i--)
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine("Faktoriyel İşleminin sonucu {0}", sonuc);

            //Console.ReadLine();
            #endregion

            #region 1'den 100 e kadar çift sayıları toplayarak ekrana yazdıran programı yazınız 

            //int toplam = 0;

            //for (int i = 1; i <=100; i++)
            //{
            //    if(i%2==0)
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine("Toplam ="+toplam);
            //Console.ReadKey();
            #endregion

            //Console.WriteLine("Çarpım Tablosu");
            //for (int i = 1; i <=9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.WriteLine("{0}x{1}={2}",i,j,i*j);
            //    }
            //    Console.WriteLine("-----------------------");
            //}
            //Console.ReadKey();

            Console.WriteLine("Faktoriyeli hesaplanacak sayıyı giriniz");
            int gelensayi =int.Parse( Console.ReadLine());

            int sonuc = 1;

            for (int i = gelensayi; i > 0; i--)
            {
                sonuc *= i;
            }
            Console.WriteLine("Sonuc={0}",sonuc);
            Console.ReadLine();
            
        }
    }
}
