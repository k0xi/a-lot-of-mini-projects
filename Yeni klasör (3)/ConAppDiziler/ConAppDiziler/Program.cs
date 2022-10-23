using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDiziler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kısa kenar giriniz");
            int kisa = int.Parse(Console.ReadLine());
            Console.WriteLine("uzun kenar giriniz");
            int uzun = int.Parse(Console.ReadLine());

            int alan = kisa * uzun;

            Console.WriteLine("Sonuc {0}",alan);
            Console.ReadKey();
        }
    }
}
