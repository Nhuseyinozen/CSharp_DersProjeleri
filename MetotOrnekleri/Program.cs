using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOrnekleri
{
    internal class Program
    {

        //Bir araca ait gittiği yol ve gidiş süresi klavyeden girildiğinde ortalama hızı hesaplayıp ekrana yazan
        // C# konsol uygulamasını yapınız.


        static void hiz(decimal yol, decimal süre)
        {
            decimal ortalamaHiz = yol / süre;
            Console.Write("Aracın ortalama hızı {0} KM/S", ortalamaHiz);



        }


        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba..............");

            Console.Write("Gitmek istediğiniz güzergah uzunluğunu giriniz ;");
            decimal yolkm = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Gidilen güzergahın süresini giriniz ;");
            decimal gidilenSüre = Convert.ToDecimal(Console.ReadLine());

            hiz(yolkm, gidilenSüre);
            Console.ReadKey();



        }



    }
}
