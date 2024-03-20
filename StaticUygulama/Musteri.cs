using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticUygulama
{
    public class Musteri
    {

        #region Sanal Database

        static ArrayList musteriDataBase;

        #endregion

        #region Static Yapıcı Metot

        static Musteri()
        {
        
        musteriDataBase = new ArrayList();
        
        
        }
        #endregion


        #region
        public int musteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }

        private string _kullaniciAdi;
        #endregion

        #region Kapsülleme

        public string KullaniciAdi 
        {
            get
            {
                return this._kullaniciAdi;
            }


            set { }
        }

        #endregion


    }
}
