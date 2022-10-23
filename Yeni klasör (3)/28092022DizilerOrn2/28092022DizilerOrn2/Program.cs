using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28092022DizilerOrn2
{
    class Program
    {
        static void Main(string[] args)
        {
            // klavyeden girilen 10 sayının teklerin ve çiftlerin toplamını yazdıran program


            int[] sayilar = new int[10];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Sayi giriniz");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Clear();

            int cifttoplam = 0;
            int tektoplam = 0;

            foreach (int  sayi in sayilar)
            {
                if (sayi % 2 == 0)
                    cifttoplam += sayi;
                else
                    tektoplam += sayi;
            }

            Console.WriteLine(" Tek sayıların toplamı :{0} cift sayıların toplamı :{1}",tektoplam,cifttoplam);
            Console.ReadKey();
        }
    }
}
