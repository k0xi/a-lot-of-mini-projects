using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28092022Orn3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aranan kelime kaç defa var ekrana yazdıran program
            // Excell CTRL +F komutu

            string[] isimler = new string[10];//bir dizi tanımlanır boyutu 10

            for (int i = 0; i < isimler.Length; i++)// for döngüsü kullandım dizi boyutu kadar 
            {
                Console.WriteLine("Bir isim giriniz");// kullanıcı isimleri klavyeden girsin
                isimler[i] = Console.ReadLine();
            }

            Console.Clear();

            Console.WriteLine("Aranacak ismi giriniz");
            string aranacak = Console.ReadLine();
            int adet = 0;

            for (int i = 0; i < isimler.Length; i++) 
            {
                if (isimler[i] == aranacak)
                    adet++;
            }
            Console.WriteLine("Aranan Kelimesi {0} bu kadar adet {1} geçmiştir",aranacak,adet);
            Console.ReadKey();
        }
    }
}
