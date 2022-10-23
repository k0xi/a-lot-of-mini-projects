using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppFaktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Faktoriyel hesaplanacak bir sayı giriniz");
            int sayi =int.Parse(Console.ReadLine());


            int sonuc=1;
            for (int i = sayi; i >1; i--)
            {
                sonuc *= i;
                
            }
            Console.WriteLine("Faktoriyel Sonuc"+ sonuc);
            Console.ReadLine();
        }
    }
}
