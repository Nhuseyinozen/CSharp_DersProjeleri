using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OppSinif
{
    internal class Araba
    {
        public string marka;
        public string model;
        public int yil;
        public decimal km;
        public int yakitTipi; // dizel :121 , benzin:122
        public int vitesTipi; // otomatik : 10 , manuel : 20 
        public decimal alisFiyat;
        public decimal satisFiyat;
        public decimal maxIndirim;
        public decimal fiyat;

        public Araba()
        {

        }
        public Araba(string _marka, string _model)
        {
            marka = _marka;
            model = _model;
        }

        public Araba(string _marka, string _model, int _yil)
        {
            marka = _marka;
            model = _model;
            yil = _yil;
        }

        public Araba(string _marka, string _model, int _yil, decimal _km)
        {
            marka = _marka;
            model = _model;
            yil = _yil;
            km = _km;
        }

        public void BilgileriGoruntule()
        {
            Console.WriteLine("Marka - {0} , Model - {1} , Yıl - {2} ", marka, model, yil);
        }

        public void FiyatAta(decimal _fiyat)
        {

            decimal fiyatHesapla = satisFiyat - maxIndirim;

            if (_fiyat < fiyatHesapla)
            {
                Console.WriteLine("Geçersiz Fiyat Girişi ! ");
            }
            else
            {
                this.fiyat = _fiyat;
                Console.WriteLine("Fiyat Güncellendi : {0}", this.fiyat);
            }




        }


    }
}
