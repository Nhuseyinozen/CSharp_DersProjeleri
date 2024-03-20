using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppSinif
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Araba A1 = new Araba("Opel", "Corsa", 2012, 15000);
            A1.alisFiyat = 15000;
            A1.satisFiyat = 30000;
            A1.maxIndirim = 2000;

            A1.FiyatAta(31000);
            A1.BilgileriGoruntule();
            Console.ReadKey();
            



        }
    }
}
