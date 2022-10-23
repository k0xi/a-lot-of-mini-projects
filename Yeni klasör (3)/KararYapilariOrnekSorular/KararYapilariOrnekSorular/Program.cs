using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariOrnekSorular
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //  Örnek 1)Kişi Cinsiyet ve yaşını alalım yaşı 20' den büyük olanlardan erkek ise askerlik durumunu kontrol edelim

            string _Cinsiyet;

            int _Yas;

            Console.WriteLine("Cinsiyetinizi Giriniz! Erkek için : E Bayan için :B");

            _Cinsiyet = Console.ReadLine();

            Console.WriteLine("Yasınızı Giriniz");

            _Yas = Convert.ToInt32(Console.ReadLine());

            if (_Cinsiyet == "E" && _Yas >= 20)
            {
                Console.WriteLine("Askere Gidebilirsiniz");
                Console.Read();
            }
            else if (_Cinsiyet == "E" && _Yas < 20)
            {
                Console.WriteLine("Askerlik İçin Uygun Değil");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Bayan Olduğunuz İçin Askerlik Yapamazsınız");
                Console.Read();
            }

            #endregion


            // Örnek 2)    Klavyeden mevsim girilmesi istenerek bu mevsime ait ayları ekranda yazan program

            /*
             
             ilkbahar - mart nisan mayis
             yaz - haziran temmuz agustos
             sonbahar - eylül ekim kasim
             kis - aralik ocak suba
             
             */

            Console.WriteLine("Mevsimlere ait aylari gösteren programa hosgeldiniz");
            Console.WriteLine("Lutfen ogrenmek istediginiz mevsimi giriniz");
            string mevsim = Console.ReadLine().ToLower();

            #region İf Kullanım Mevsimler
           // if KONTROLLÜ KULLANIM uygulamamıza ilk başlarken de dediğim gibi birden fazla yolla yapılabilinir şimdi 
           // SWİTCH - CASE KULLANIMI na bakıyor olalım alt bölümde

            if (mevsim == "ilkbahar")
            {
                Console.WriteLine("{0} mevsimine ait aylar : Mart, Nisan, Mayis", mevsim);            
            }
            else if (mevsim == "Yaz")
            {
                Console.WriteLine("{0} mevsimine ait aylar : Haziran, Temmuz, Agustos", mevsim);
            }
            else if (mevsim == "Sonbahar")
            {
                Console.WriteLine("{0} mevsimine ait aylar : Eylul, Ekim, Kasim", mevsim);
            }
            else if (mevsim == "Kis")
            {
                Console.WriteLine("{0} mevsimine ait aylar : Aralik, Ocak, Subat", mevsim);
            }
            else
            {
                Console.WriteLine("Mevsim disinda bir kelime girdiniz!");
            }
            Console.ReadKey();

          //  SWİTCH - CASE KULLANIMI

            switch (mevsim)
            {
                case "ilkbahar":
                    Console.WriteLine("{0} mevsimine ait aylar : Mart, Nisan, Mayis", mevsim);
                    break;
                case "yaz":
                    Console.WriteLine("{0} mevsimine ait aylar : Haziran, Temmuz, Agustos", mevsim);
                    break;
                case "sonbahar":
                    Console.WriteLine("{0} mevsimine ait aylar : Eylul, Ekim, Kasim", mevsim);
                    break;
                case "kis":
                    Console.WriteLine("{0} mevsimine ait aylar : Aralik, Ocak, Subat", mevsim);
                    break;
                default:
                    Console.WriteLine("Dogru bilgi giriniz!");
                    break;
            }

            Console.ReadKey();
            #endregion
        }
    }
}
