using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            double sonuc = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lütfen Listeden Seçim Yapınız");
            sb.AppendLine("Toplama : +");
            sb.AppendLine("Cıkarma : -");
            sb.AppendLine("Bölme : /");
            sb.AppendLine("Çarpma : *");
            sb.AppendLine("Mod Alma:%");


            Console.Write(sb.ToString());

            Console.WriteLine("Seçimiz :");
            string secim = Console.ReadLine();

           

            Console.WriteLine("Bir Sayı Giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci  Sayı Giriniz");
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
                    Console.Write("Yanlış Bir Seçim Yaptınız");
                    break;
            }

            string strSonuc = String.Format("Sonuç : {0}", sonuc.ToString());
            Console.WriteLine(strSonuc);

            Console.WriteLine("Çıkmak İçin Bir Tuşa Basınız");
            Console.ReadLine();
        }
    }
}
