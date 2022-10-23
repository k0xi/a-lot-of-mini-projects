using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcı adı Sinan paralo 123 ise hoş geldin admin
            //değilse ne işin var burda yazsın

            string ad = "";
            string parola = "";
            Console.WriteLine("Kullanıcı adınız nedir");
            ad = Console.ReadLine();

            Console.WriteLine("Kullanıcı parola nedir");
            parola = Console.ReadLine();


            if (ad=="Sinan" & parola == "123")
            {
                Console.WriteLine("Hoşgeldin Patron");
            }
            else
            { 
                Console.WriteLine("yetkili olmadığınız bir alandasınız çıkınız");
            }
            Console.ReadLine();
        }
    }
}
