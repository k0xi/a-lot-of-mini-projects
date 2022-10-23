using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Döngüsü 
            Calculator();
            CalculatorParallel();
            Console.ReadKey();

        }

        static void Calculator()
        {
            double sonuc = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 999999999; i++)
            {
                sonuc += Convert.ToDouble(Math.Sin(i) / Math.Cos(i));
            }
            sw.Stop();
            Console.WriteLine("Paralel Olmayan İşlemin bitme süresi : " + sw.Elapsed.TotalMilliseconds.ToString());
        }



        static void CalculatorParallel()
        {
            double sonuc = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Parallel.For(0, 99999999, i =>
            {
                sonuc += Convert.ToDouble(Math.Sin(i) / Math.Cos(i));
            });
            sw.Stop();
            Console.WriteLine("Paralel İşlemin Tamamlanma Süresi : " + sw.Elapsed.TotalMilliseconds.ToString());

        }
    }
}
