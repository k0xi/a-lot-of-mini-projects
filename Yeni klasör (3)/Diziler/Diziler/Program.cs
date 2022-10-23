using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aynı Tipte Değişkenleri bir arada kullanacaksan isek dizilerden faydalanırız
            /*
             Bir dizi tanımlarken değişken ifadesinin sonuna [] eklenir
             
            Diziler indis numaralarından oluşur.Diziler sıfıncı index başlar
             
             */

            //string[] dersler = {"Matematik","Türkçe","Tarih" };


            string[] ogrenciler = new string[3] {"Sina","Elif" };
            //ogrenciler[0] = "Bilal";
            //ogrenciler[1] = "Burak";
            //ogrenciler[2] = "Polat";
            //ogrenciler[3] = "Barış";
            //ogrenciler[4] = "Seyran";

            Console.WriteLine(ogrenciler[3]);
            Console.ReadLine();

            //string[] adlar = { "Hasan", "Kadir", "Bahtiyar","Murat" };

            // Klavyeden girilen  10 sayının ortalamasını hesaplayan programı yazınız

            int[] sayilar = new int[10];
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("sayi giriniz");
                sayilar[i] = int.Parse(Console.ReadLine());
                toplam += sayilar[i];
            }
            double ort = toplam / 10;
            Console.WriteLine("Girilen sayıların ort{0}", ort);
            Console.ReadLine();

           // ad adını okuyan program

            string[] ad = { "Kamil", "Enes", "Salim", "Eymen" };

            string metin = "";
            foreach (string isim in ad)
            {
                metin = isim;
            }
            Console.WriteLine("ad {0}",metin);
            Console.ReadLine();
        }
    }
}
