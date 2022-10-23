using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationExampleTWO
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcıdan 2 tane sayı al sayıları topla

            Console.WriteLine("Birinci sayıyı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());


            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sayıların toplamı {0}",toplam);
            Console.ReadLine();
        }
    }
}
