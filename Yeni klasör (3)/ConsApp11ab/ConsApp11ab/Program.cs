using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsApp11ab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  1)değişken tanımla
             2)kullanıcı değer al 
             3 kullanıcıdan alınan değeri değişkene ata 
             4) şart varsa bunu kontrol et
             console read
               */


            string kulad = "";
            string pswd="";

            Console.WriteLine("Kullanıcı adınızı giriniz");
            kulad = Console.ReadLine();


            Console.WriteLine("Kullanıcı parola giriniz");
            pswd = Console.ReadLine();

            if (kulad=="admin" & pswd=="123")
            {
                Console.WriteLine("Patron hoşgeldin");
            }
            else
            {
                Console.WriteLine("Yanlış Yerdeniz");
            }
            Console.ReadLine();
        }
    }
}
