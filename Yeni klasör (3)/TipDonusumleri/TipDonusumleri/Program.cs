using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tip Dönüşümleri

            #region Cast
            /*
             Cast :Bir tipteki değeri başka bir tipe dönüştürmek 
             için kullanılır.Benzer tiplerin birbirine dönüştürülmesi
             
            Önemli Not:object tipinin başka bir tipe dönüştürülmesi
            için cast yetersizdir string ve int gibi
             

            Implicity Cast Örnek :

            short kucuk = 127;
            int buyuk = kucuk;

            büyük değer aralığı küçük olanı kapsadığı için Implicity 
            cast çalışır

            Explicit Cast Örnek

             int say1 = 234999;
            short say2 = say1; // hata verir küçük bir alana büyük bir
            değer atmaya çalıştın
             
             */


            //Explicit Cast Örnek

            int say1 = 234999;
            short say2 = say1;

            #endregion
            //int say1 = 234999;
            //short say2 = (short)say1;//hata vermez fakat farklı sonuç 
            //dönderir sadece emin isen bu aralığa sıcağına yazmalısın

            
            string metin= "12345";
            int sayi = (int)metin;//cast işlemi çalışmaz string cast olmaz

            //Böyle durumlarda Convert yada parse denenmelidir

            //Örnek Uygulamalar 
        }
    }
}
