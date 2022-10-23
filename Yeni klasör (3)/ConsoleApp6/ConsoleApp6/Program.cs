using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Ay Giriniz");
            string isim = Console.ReadLine();

            switch(isim)
            {
                case "ocak":
                    Console.Write("1. ay");
                    break;
                case "şubat":
                    Console.Write("2. ay");
                    break;
                case "mart":
                    Console.Write("3. ay");
                    break;
                case "nisan":
                    Console.Write("4. ay");
                    break;
                case "mayıs":
                    Console.Write("5. ay");
                    break;
                case "haziran":
                    Console.Write("6. ay");
                    break;
                case "temmuz":
                    Console.Write("7. ay");
                    break;
                case "ağustos":
                    Console.Write("8. ay");
                    break;
                case "elül":
                    Console.Write("9. ay");
                    break;
                case "ekim":
                    Console.Write("10. ay");
                    break;
                case "kasım":
                    Console.Write("11. ay");
                    break;
                case "aralık":
                    Console.Write("12. ay");
                    break;
            }
            Console.ReadLine();

        }
    }
}
