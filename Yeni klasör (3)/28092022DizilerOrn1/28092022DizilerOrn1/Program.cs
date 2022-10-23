using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28092022DizilerOrn1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen 10 sayının ortalamasını hesaplayan programı yazınız

            int[] sayilar = new int[10];
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Bir sayı giriniz");
                toplam +=int.Parse( Console.ReadLine());
            }
            double ort;
            ort = toplam / 10;
          
            Console.WriteLine("Sayıların Ortalaması {0}",ort);
            Console.ReadLine();
        }

      
    }
}
