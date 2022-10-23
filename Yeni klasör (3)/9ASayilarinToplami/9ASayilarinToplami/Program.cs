using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9ASayilarinToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı Giriniz");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci sayı Giriniz");
            int sayi2 = int.Parse(Console.ReadLine());

            int sonuc = sayi1 + sayi2;

            Console.WriteLine("İşlemnin Sonucu {0}",sonuc);
            Console.ReadLine();

        }
    }
}
