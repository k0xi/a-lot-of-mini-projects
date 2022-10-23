using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9bilkhaftahesapmakinasi
{
    class Program
    {
        static void Main(string[] args)
        {
            double sonuc=0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Listeden bir işlem türü seçiniz");
            sb.AppendLine("===============================");
            sb.AppendLine("Toplama +");
            sb.AppendLine("Çıkarma -");
            sb.AppendLine("Bölme /");
            sb.AppendLine("Çarpma *");
            sb.AppendLine("Mod alma %");

            Console.WriteLine(sb.ToString());

            string secim = Console.ReadLine();
            Console.WriteLine(secim);

            Console.WriteLine("Birinci Sayı Giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci Sayı Giriniz");
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
                    Console.WriteLine("Yanlış Seçim yaptın");
                    break;
            }
            string strSonuc = String.Format("Sayıların Sonucu :{0}", sonuc.ToString());
            Console.WriteLine(strSonuc);

            Console.WriteLine("Çıkmak İçin bir tuşa basınız");
            Console.ReadLine();
        }
    }
}
