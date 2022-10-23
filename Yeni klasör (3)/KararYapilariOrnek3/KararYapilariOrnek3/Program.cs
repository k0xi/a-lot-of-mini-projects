using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Karenin bir kenar uzunluğunu giriniz");
            int kenaruzunluk = int.Parse(Console.ReadLine());

            int sonuc = kenaruzunluk * kenaruzunluk;

            Console.WriteLine("Sayıların Sonucu {0}",sonuc);
            Console.ReadLine();
        }
    }
}
