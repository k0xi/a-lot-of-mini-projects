using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararyapilariOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir renk giriniz");
            string renk = Console.ReadLine();

            if (renk == "Blue")
            {
                Console.WriteLine("Aydın say Like Blue");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Aydın don't like blue");
                Console.ReadLine();
            }
           
        }
    }
}
