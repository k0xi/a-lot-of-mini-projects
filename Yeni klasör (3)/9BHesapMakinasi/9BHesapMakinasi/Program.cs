using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9BHesapMakinasi
{
    class Program
    {
        static void Main(string[] args)
        {
            double sonuc=0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Listeden Bir Seçim Yapınız");
            sb.AppendLine("==========================");
            sb.AppendLine("Toplama +");
            sb.AppendLine("Çıkarma -");
            sb.AppendLine("Bölme /");
            sb.AppendLine("Çarpma *");
            sb.AppendLine("Mod Alma %");

            Console.WriteLine(sb.ToString());

            string secim = Console.ReadLine();

            Console.WriteLine("Birinci Sayıyı Giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Giriniz");
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
                    Console.WriteLine("Yanlış bir seçim yaptınız");
                    break;
            }

            string strSonuc = String.Format("Yapmış olduğunuz işleminin sonucu {0}", sonuc);
            Console.WriteLine(strSonuc);
            Console.WriteLine("Çıkmak İçin Entere Basın ");
            Console.ReadLine();
        }
    }
}
