using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenTipleriVeDonusumler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Temel Veri Tipleri 
            #region 
            /*
             Tam Sayılar için 

             byte:0-255 arasında değer tutan sayı tipidir

             sbyte: -128 ile 127 arasında değer tutar

             short :2byte alan kaplar -32768 ile 32767 arasında değer tutar

             ushort:2bytealan kaplar 0 ile 655335 arasında değer tutar 

             int :4 byte yer kaplar varsayılan sayısal değerdir -1.14 milyar 
             ve 1,14 milyar arasında değer tutar

            uint:0 dan başlar 2.28 milyar değer tutar 4byte alan kaplar

            long :8byte alan kaplar -çoktan +çoka kadar tam sayı değeri tutar
            
            ulong :0 dan başlar (19 hane yer kaplar)8byte alan kaplar

             */

            #endregion

            #region 
            //Ondalıklı Tipler 


            /*
             Küçükten büyüğe sıralanışı aşağıdaki gibidir
             float:uzunluk birimlerinde ve ölçü birimlerinde kulanılır
             double:matematiksel işlemler için kullanılır
             decimal:Parasal ifadelerde kullanılır
             
             */
            #endregion


            #region
            //Mantıksal Tipler 
            /* 
            * bool:True false değer tutar 1bit yer kaplar

            
             
             */

            #endregion

            #region
            //Metinsel Tipler
            /*
             Char :1 karakter tutar
             string:1' den fazla karakterden oluşan metinlerdir
             */
            #endregion

            #region

            //object Veri Tipi:
            /*
             C# yazılım dilinde herşey bir nesnedir.Bu aşamada 
             object veri tipini çöp kutusuna benzetebiliriz.
             Yani içine ne atarsanız o olur

            Tabi bu tehlikeli bir iştir.Birden fazla yazılımcının
            bulunduğu ortamda o anda object veri tipinin hangi
            değişken tuttuğu anlaşılması zordur

            Boxing ve Unboxing işlemleri için kullanılır

            object içine atılan değeri cast edilip değere ulaşmak için
            unboxing yaparız.

            Kutula çıkar mantığı
             */
            #endregion

            //Tip Dönüşümleri

            #region Toplu yorum
            #endregion
        }
    }
}
