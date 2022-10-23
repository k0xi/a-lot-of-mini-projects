using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28092022DizilerOrnek4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen 10 adet öğrencinin  içinden Rastgele Öğrenci Seç Giyotin

            string[] ogrenciler = new string[10];

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine("Öğrenci İsmi Giriniz");
                ogrenciler[i] = Console.ReadLine();
            }

            Random rnd = new Random();
            int gelensayi =rnd.Next(0,ogrenciler.Length);

            Console.Clear();

            Console.WriteLine(ogrenciler[gelensayi]);
            Console.ReadKey();


        }
    }
}
