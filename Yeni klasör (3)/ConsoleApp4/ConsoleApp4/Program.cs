using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ikinci sayı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());

            int sonuc = sayi1 + sayi2;

            Console.WriteLine("İşlemin Sonucu {0}",sonuc);
            Console.ReadLine();
        }
    }
}
