using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 inci sayıyı giriniz");


            int sayi1 = Convert.ToInt32(Console.Read());

            Console.WriteLine("2 inci sayıyı giriniz");


            int sayi2 = Convert.ToInt32(Console.Read());

            Console.WriteLine("3 inci sayıyı giriniz");


            int sayi3 = Convert.ToInt32(Console.Read());

            int toplam = sayi1 + sayi2 + sayi3;

            Console.WriteLine("Girilen sayilarin toplamı", toplam);
            Console.ReadLine();
        }
    }
}
