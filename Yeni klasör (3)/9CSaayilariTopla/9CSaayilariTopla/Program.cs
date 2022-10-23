using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9CSaayilariTopla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci Sayı Giriniz");
            Console.Read();
            //int sayi3 = Console.ReadLine();
            Console.WriteLine("ikinci Sayı Giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;

            Console.WriteLine("sayıların toplamı {0}", toplam);
            Console.ReadLine();
        }
    }
}
