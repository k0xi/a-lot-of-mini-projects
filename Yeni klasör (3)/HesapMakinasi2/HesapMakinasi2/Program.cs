using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinasi2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sonuc = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lütfen Listeden Seçim Yapınız");
            sb.AppendLine("=============================");

            sb.AppendLine("Toplama : +");
            sb.AppendLine("Çıkarma : -");
            sb.AppendLine("Çarpma : *");
            sb.AppendLine("Bölme : /");
            sb.AppendLine("Mod Alma %");

            Console.WriteLine(sb.ToString());
           
            string secim =Console.ReadLine();
            Console.WriteLine("Seçiminiz {0}",secim);

            Console.WriteLine("Birinci Sayı Giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci Sayı Sayı Giriniz");
            int sayi2 = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;

                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
                case "%":
                    sonuc = sayi1 % sayi2;
                    break;
                default:
                    Console.WriteLine("Listede Olmayan Bir Seçim Yaptınız");

                    break;
            }

            string strSonuc = String.Format("İşlemin Sonucu {0}", sonuc.ToString());

            Console.WriteLine(strSonuc);

            Console.WriteLine("Çıkmak İçin Entere Basınız");
            Console.ReadLine();

        }
    }
}
