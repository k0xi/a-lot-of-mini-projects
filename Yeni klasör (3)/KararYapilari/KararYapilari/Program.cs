using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan kullanıcı ismi ve parola isteyiniz
            //kullanıcı adı = admin parolası =123 ise hoş geldin patron
            //değilse yanlış yerdesiniz

            #region If karar yapısı
           /* Belirli bir koşul sağlandığında kullanılır
            true yada false değerine göre bloklar içinden
            if ,else if ,else bloklarına girer

            Örnek Kullanıcıdan alınan iki sayının büyüklük
            küçüklüğüne bakan programı yazınız*/

            // int say1, say2;
            //Console.Write("Birinci Sayıyı Giriniz");
            //say1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci Sayıyı Giriniz");
            //say2 = Convert.ToInt32(Console.ReadLine());

            //if (say1 > say2)
            //{

            //    Console.WriteLine("Girilen sayılardan {0} büyüktür {1}", say1, say2);
            //}
            //else if (say2 > say1)
            //{
            //    Console.WriteLine("Girilen sayılardan {0} büyüktür {1}", say2, say1);
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar Eşittir");
            //}
            //Console.ReadLine();



            #endregion

            #region swicth case
            /*Birden Fazla seçeneğin bulunduğu durumlarda
            seçme işlemi yapılmaktadır

            Örnek Klayeden girilen sayı hangi gün bulan programı yazınız


            */
            #endregion
            #region

            int sayi;
            Console.Write("Bir sayı giriniz");

            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi <= 7 & sayi != 0)
            {
                switch (sayi)
                {
                    case 1:
                        Console.WriteLine("Pazartesi");
                        break;
                    case 2:
                        Console.WriteLine("Salı");
                        break;
                    case 3:
                        Console.WriteLine("Çarşamba");
                        break;
                    case 4:
                        Console.WriteLine("Perşembe");
                        break;
                    case 5:
                        Console.WriteLine("Cuma Mübarek Gün");
                        break;
                    case 6:
                        Console.WriteLine("Cumartesi");
                        break;
                    case 7:
                        Console.WriteLine("Pazar");
                        break;
                    default:
                        Console.WriteLine("hatalı");
                        break;

                }

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Girilen değer haftanın gün sayısından büyüktür");
            }
            Console.ReadLine();
            #endregion


        }
    }
    }
