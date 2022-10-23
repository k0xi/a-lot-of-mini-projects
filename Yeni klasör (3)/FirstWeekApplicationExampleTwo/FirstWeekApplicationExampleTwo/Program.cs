using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekApplicationExampleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz ");
            int sayi1=Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayı giriniz ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;

            Console.WriteLine("Sayıların Toplamı "+toplam);
            Console.ReadLine();


            

        }
    }
}
