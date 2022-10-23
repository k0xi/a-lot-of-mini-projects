using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
      
        static void Main(string[] args)
        {
            double sonuc=0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("İşleminizi Seçiniz");
            sb.AppendLine("=========================");
            sb.AppendLine("Çarpma : *");
            sb.AppendLine("Toplama: +");
            sb.AppendLine("Cıkarma : -");
            sb.AppendLine("Bölme : /");
            sb.AppendLine("Mod Alma: %");
            sb.AppendLine("Temizle :#");

            Console.WriteLine(sb.ToString());
            Console.WriteLine("Seçiminiz");
            string secim = Console.ReadLine();


            Console.WriteLine("Bir sayı Giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayı Giriniz");
            int sayi2 = int.Parse(Console.ReadLine());

            


            

            switch (secim)
            {

                case "+":
                    sonuc = sayi1 + sayi2;

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

                case "-":
                    sonuc = sayi1 - sayi2;

                    break;

                case "#":
                    Console.Clear();

                    break;

                default:
                    Console.Write("Yanlış bir seçim yaptınız");
                    break;
            }
            string strSonuc = String.Format("Sonuc : {0} ",sonuc.ToString());
            Console.WriteLine(strSonuc);
            Console.WriteLine("Çıkmak için Entere Basınız ");
            Console.ReadLine();
        }
    }
}
