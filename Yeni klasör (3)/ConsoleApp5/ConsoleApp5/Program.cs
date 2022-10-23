using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz. ");
            int sayi = Convert.ToInt32(Console.ReadLine());


            switch (sayi)
            {
                case 1:
                    Console.Write("Pazartesi");
                    break;
                case 2:
                    Console.Write("Salı");
                    break;
                case 3:
                    Console.Write("Çarşamba");
                    break;
                case 4:
                    Console.Write("Perşembe");
                    break;
                case 5:
                    Console.Write("Cuma");
                    break;
                case 6:
                    Console.Write("Cumartesi");
                    break;
                case 7:
                    Console.Write("Pazar");
                    break;
                default:
                    Console.Write("Hata");
                    break;
            }
            Console.ReadLine();
        }
    }
}
