using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.MusteriId = 1;
            M1.isim = "Hüseyin";
            M1.soyisim = "Özen";
            M1.emailAdres = "hüseyin.özen@gmail.com";
            M1.KullaniciAdi = "hüseyin.özen";
            M1.sifre = "1";

            Musteri.MusteriEkle(M1);
             

        }
    }
}
