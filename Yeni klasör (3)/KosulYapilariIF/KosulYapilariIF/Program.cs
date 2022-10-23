using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulYapilariIF
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Kullanıcı Adınızı Giriniz");
            string ad = Console.ReadLine();

            Console.Write("Kullanıcı Parola Giriniz");
            string psw = Console.ReadLine();

            
            if (ad == "Deneme" & psw == "12345")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Merhaba Sahip");
               
                Console.ReadLine();

            }
            else
            { 
                Console.WriteLine("Kullanıcı Bulunamadı");
                Console.ReadLine();
            }
            Console.Clear();
        }
    }
}
