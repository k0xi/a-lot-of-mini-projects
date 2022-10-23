using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppOrnekUygulamaKararYapilari5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Örnek 3)Kullanıcıdan alınan   notların ortalamasını hesaplayan programı yazınız

            //int Toplam = 0;

            //Console.WriteLine("Kac Adet Notun Girilecegini Yaziniz\n");

            //string GelenSayi = Console.ReadLine();
            //Console.WriteLine(GelenSayi + "adet Notun ortalamasi hesaplanacak");
            //int donussayisi = Convert.ToInt32(GelenSayi);

            //for (int i = 1; i <= donussayisi; i++)
            //{
            //    Console.Write(i + "inci not\n");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Toplam = Toplam + sayi;
            //}
            //double ort = (double)Toplam / donussayisi;
            //Console.WriteLine("Girilen Notun Ortalamasi =" + ort);
            //Console.ReadKey();
            #endregion

            #region Örnek 4)Klavyeden girilen 5 adet sayının en büyüğünü bulan program


            //int sayi, enbuyuk = 0;

            ////
            //Console.WriteLine("Klavyeden girilen 5 adet sayının en büyüğünü bulan program....");

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("{0} inci sayi giriniz.", i);
            //    sayi = Convert.ToInt16(Console.ReadLine());
            //    if (i == 1)
            //        enbuyuk = sayi;
            //    if (sayi > enbuyuk)
            //        enbuyuk = sayi;

            //}
            //Console.WriteLine("En buyuk sayi {0}", enbuyuk);
            //Console.ReadKey();
            #endregion

            #region Örnek 5)Girilen Üç Sayıdan En buyuk olanını bulan program

            //int sayi1, sayi2, sayi3;
            //Console.WriteLine("Birinci Sayi Giriniz");

            //sayi1 = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("ikinci Sayi Giriniz");

            //sayi2 = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("ucuncu Sayi Giriniz");

            //sayi3 = Convert.ToInt16(Console.ReadLine());

            //int enbuyuk = 0;

            //if (sayi1 > enbuyuk)
            //    enbuyuk = sayi1;
            //if (sayi2 > enbuyuk)
            //    enbuyuk = sayi2;
            //if (sayi3 > enbuyuk)
            //    enbuyuk = sayi3;
            //Console.WriteLine("{0} en buyuk olan sayi", enbuyuk);
            //Console.ReadKey();
            #endregion

            #region Örnek 7)100 lük sistemdeki notun 5 lik sisteme ceviren program

            //int not = 0;

            //Console.WriteLine("100 lük sistemdeki notun 5 lik sisteme ceviren program");

            //Console.WriteLine("Notunuzu Giriniz");
            //not = int.Parse(Console.ReadLine());

            //if (not >= 0 && not < 25)
            //    Console.WriteLine("Notunuz 0 ");
            //if (not >= 25 && not < 45)
            //    Console.WriteLine("Notunuz 1 ");
            //if (not >= 45 && not < 55)
            //    Console.WriteLine("Notunuz 2 ");
            //if (not >= 55 && not < 70)
            //    Console.WriteLine("Notunuz 3 ");
            //if (not >= 70 && not < 85)
            //    Console.WriteLine("Notunuz 4 ");
            //if (not >= 85 && not < 100)
            //    Console.WriteLine("Notunuz 5 ");

            Console.ReadKey();


            #endregion

            #region Örnek 8)Klavyeden Girilen 10 sayının toplamı

            //int sayi;
            //int toplam = 0;

            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine("{0}. inci Sayi giriniz", i);
            //    sayi = Convert.ToInt16(Console.ReadLine());
            //    //toplam = toplam+sayi;
            //}
            //Console.WriteLine(" Sayilarin Toplami{0}\n", toplam);
            //Console.ReadKey();

            #endregion

            #region Örnek 9)Klavyeden Girilen Adı ,Soyadı girilen adet kadar ekrana yazdıran program
            //string ad = "";
            //string soyad = "";
            //int adet;

            //Console.WriteLine("Adinizi Giriniz ");
            //ad = Console.ReadLine();

            //Console.WriteLine("Soyadinizi Giriniz ");
            //soyad = Console.ReadLine();

            //Console.WriteLine("Adinizi Kac Defa Yazilsin");
            //adet = int.Parse(Console.ReadLine());

            //for (int i = 0; i < adet; i++)
            //{
            //    Console.WriteLine("{0} Adiniz={1} Soyadiniz={2} ", i, ad, soyad);
            //}
            //Console.ReadKey();
            #endregion

            #region Örnek 10)Klavyeden Girilen Sayi Tek mi Çift mi bulan program
            //int sayi;

            //Console.WriteLine("Kontrol Edilcek Sayiyi Giriniz");
            //sayi = int.Parse(Console.ReadLine());

            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Girilen Sayı {0} cift sayidir", sayi); Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("Girilen Sayı {0} tek sayidir", sayi); Console.ReadKey();
            //}
            #endregion

        }
    }
}
