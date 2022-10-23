using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9ahesapMakinasi
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lütfen Listeden Bir seçim yapınız");
            sb.AppendLine("=================================");
            sb.AppendLine("Topla +");
            sb.AppendLine("Çıkarma -");
            sb.AppendLine("Çarpma *");
            sb.AppendLine("Bölme /");
            sb.AppendLine("Mod Alma %");

            Console.WriteLine(sb.ToString());
            Console.ReadLine();

            string secim = Console.ReadLine();

            Console.WriteLine("Bir sayi giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("İki sayi giriniz");
            int sayi2 = int.Parse(Console.ReadLine());

        }
    }
}
