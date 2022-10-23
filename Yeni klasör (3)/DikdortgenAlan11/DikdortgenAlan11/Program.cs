using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenAlan11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Uzun kenar yaz");
            int uzun = int.Parse(Console.ReadLine());

            Console.WriteLine("Kisa kenar yaz");
            int kisa = int.Parse(Console.ReadLine());

            int sonuc = uzun * kisa;

            Console.WriteLine("Alan Sonuc {0} ",sonuc);
            Console.ReadLine();
        }
    }
}
