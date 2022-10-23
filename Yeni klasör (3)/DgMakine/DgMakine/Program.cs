using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgMakine
{
    class Program
    {
        static void Main(string[] args)
        {
            double sonuc=0;
            StringBuilder sb = new StringBuilder();//instance bir örnek
            sb.AppendLine("Listeden bir işlem seçiniz");
            sb.AppendLine("============================");
            sb.AppendLine("Toplama +");
            sb.AppendLine("Çıkarma -");
            sb.AppendLine("Bölme /");
            sb.AppendLine("Çarpma *");
            sb.Append("Mod Alma %");

            Console.WriteLine(sb.ToString());
            string secim = Console.ReadLine();

            Console.WriteLine("Seciminiz {0}",secim);

            Console.WriteLine("Birinci sayı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayı giriniz");
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
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    break;
            }
            string strsonuc = String.Format("Sonuç {0}",sonuc);
            Console.WriteLine(strsonuc);
            Console.WriteLine("Çıkmak için tuşa bas");
            Console.ReadLine();
        }
    }
}
