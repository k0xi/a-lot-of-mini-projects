﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Asilinecek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kalvyeden girilen 10 sayının ortalamasını alan programı yazınız
            int[] sayilar = new int[10];

            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Bir sayi giriniz");
                sayilar[i] = int.Parse(Console.ReadLine());
                toplam += sayilar[i];
            }
            Console.Clear();
            double ort = toplam / 10;
            Console.WriteLine("Sayıların ort {0}",ort);
            Console.ReadKey();





        }
    }
}
