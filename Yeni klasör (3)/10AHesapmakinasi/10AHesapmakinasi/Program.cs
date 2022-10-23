using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10AHesapmakinasi
{
    class Program
    {
        static void Main(string[] args)
        {
            double sonuc = 0;
            StringBuilder sb = new StringBuilder();
           sb.AppendLine("Listeden Bir seçim yapınız");

            sb.AppendLine("=============================");
            sb.AppendLine("Toplama +");
            sb.AppendLine("Çıkarma -");
            sb.AppendLine("Bölme /");
            sb.AppendLine("Çarpma *");
            sb.AppendLine("Mod Alma %");

            Console.WriteLine(sb.ToString());
            Console.ReadLine();

            string secim = Console.ReadLine();

            Console.WriteLine("Seçiniz {0}", secim);

            Console.WriteLine("Bir sayı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("İki sayı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;

                case "-":
                    sonuc = sayi1- sayi2;
                    break;

                case "/":
                    sonuc = sayi1 /sayi2;

                    break;

                case "*":
                    sonuc = sayi1 *sayi2;
                    break;


                case "%":
                    sonuc = sayi1 %sayi2;
                    break;








                default:
                    Console.WriteLine("Listede olmayan Bir seçim yaptınız");
                    break;
            }

            string strSonuc = String.Format("Sayıların sonucu {0}", sonuc);
            Console.WriteLine(strSonuc);
            Console.ReadLine();
        }
    }
}
