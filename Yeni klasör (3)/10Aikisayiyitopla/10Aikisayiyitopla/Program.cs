using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Aikisayiyitopla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı Giriniz");
         int sayi1=int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci sayı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Sayıların Toplamı {0}", sonuc);
            Console.ReadLine();
        }
    }
}
