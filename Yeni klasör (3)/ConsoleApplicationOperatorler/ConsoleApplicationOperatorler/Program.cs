using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            //Oparetörler 
            #region
            /*
             Matematiksel Operatörler 

            +-/*:4 işlem operatörleridir
            ++: sayıları birer birer artırmaya yarar
            --:sayıları birer birer azaltmaya yarar
            % : Mod almaya yarar bir sayının bölümünden kalanı alır
            tekmi çift mi uygulamaları
            +=:sayıyı kendisi ile toplamaya yarar 
            -=: sayıdan kendisi kadar çıkarır
            /=: sayıyı kendisi ile böler
            *=: sayıyı kendisi kadar katlar
            =: eşittir değer atamalarında kullanılır 
            * 
             */
            #endregion

            #region
            /*
            İLişkisel Operatörler 
            ==: Eşit mi
            <:küçük mü
            >:büyük mü
            <=:Küçük veya eşit mi
            >=:Büyük veya eşit mi
            !=:Eşit değildir


             
             */

            #endregion


            int A = 5;
            //A *= A;
            //A += A;
            //A -= A;
            //A /= A;
            //A %= A;
            Console.WriteLine("Sayı toplamı {0}",A);
            Console.ReadLine();

            


        }
    }
}
