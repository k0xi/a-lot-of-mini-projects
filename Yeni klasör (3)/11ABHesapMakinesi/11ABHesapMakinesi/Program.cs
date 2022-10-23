using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ABHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double sonuc=0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Listeden Bir İşlem Seçiniz");
            sb.AppendLine("===========================");
            sb.AppendLine("Toplama +");
            sb.AppendLine("Çıkarma -");
            sb.AppendLine("Çarpma *");
            sb.AppendLine("Bölme /");
            sb.AppendLine("Mod Alma %");

            Console.WriteLine(sb.ToString());
            string secim = Console.ReadLine();

            Console.WriteLine("Bir sayi giriniz");
            int sayi1 = int.Parse(Console.ReadLine());


            Console.WriteLine("ikinci sayi giriniz");
            int sayi2 = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;

                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "%":
                    sonuc = sayi1 % sayi2;
                    break;

                default:
                    Console.WriteLine("Yanlış Seçim");
                    break;
            }
            string strSonuc = String.Format("İşleminizin Sonucu {0}", sonuc);
            Console.WriteLine(strSonuc);
            Console.ReadLine();

            Console.WriteLine("Çıkmaz Entere Basınız");
            Console.ReadLine();

        }
      
    }
}
