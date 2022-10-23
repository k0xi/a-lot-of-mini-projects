using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30092022Diziler9bOrnek5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[100];
            double ortalama;
            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Bir sayı giriniz");
                sayilar[i] = int.Parse(Console.ReadLine());
                toplam += sayilar[i];
            }
            ortalama = toplam / 100;

            Console.WriteLine("sayıların ortalamsı{0}",ortalama);
            Console.ReadKey();











        }
    }
}
