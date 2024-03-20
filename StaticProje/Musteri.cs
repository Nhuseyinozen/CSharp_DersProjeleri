using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProje
{
    public class Musteri
    {
        #region Sanal Database
        static ArrayList musteriDatabase;
        #endregion

        #region Static Yapıcı Metot

        static Musteri()
        {
            musteriDatabase = new ArrayList();
        }
        #endregion

        #region Field
        public int MusteriId { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        public string sifre { get; set; }

        #endregion


        #region Kapsullenme
        private string _kullaniciAdi;
        public string KullaniciAdi
        {
            get { return _kullaniciAdi; }

            set
            {

                bool kullaniciAdiKontrol = musteriKullaniciAdiKontrol(value);
                if (kullaniciAdiKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistem içerisinde kayıtlı");
                    this._kullaniciAdi = string.Empty;
                }
                else
                {
                    this._kullaniciAdi = value;
                }

            }
        }
        #endregion


        #region Static metotlar

        static private bool musteriKullaniciAdiKontrol(string _kullaniciAdi)
        {
            bool kontrol = false;
            for (int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if (Temp.KullaniciAdi == _kullaniciAdi)
                {
                    kontrol = true;
                    break;

                }
            }

            return kontrol;
        }

        public static void MusteriEkle(Musteri M)
        {
            #region Parametre kontrol


            if (M != null && !string.IsNullOrEmpty(M.KullaniciAdi) && !string.IsNullOrEmpty(M.emailAdres))
            {
                bool emailAdresKontrol = musteriEmailAdresKontol(M.emailAdres);
                if (emailAdresKontrol)
                {
                    Console.WriteLine("Eklemek isteidğiniz kullanıcı sistemde kayıtlı");
                }
                else
                {
                    musteriDatabase.Add(M);
                    Console.WriteLine("Yeni kayıt işlemi başarılı");
                }

            }
            #endregion
        }

        static bool musteriEmailAdresKontol(string _emailAdres)
        {
            bool kontrolemail = false;
            for (int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if (Temp.emailAdres == _emailAdres)
                {
                    kontrolemail = true;
                    break;
                }
                
            }

            return kontrolemail;
        }

        #endregion
    }
}
