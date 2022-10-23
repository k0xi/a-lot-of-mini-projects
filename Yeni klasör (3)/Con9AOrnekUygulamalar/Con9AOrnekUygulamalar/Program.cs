using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con9AOrnekUygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {

            //faktoriyel hesaplanacak sayiyi yazınız
            Console.WriteLine("Faktoriyel hesaplanacak sayi giriniz");
            int sayi = int.Parse(Console.ReadLine());

            int sonuc = 1;

            for (int i = sayi; i >= 1; i--)
            {
                sonuc *= i;
            }
            Console.WriteLine("Sonuc {0}",sonuc);
            Console.ReadKey();
        }
    }
}
