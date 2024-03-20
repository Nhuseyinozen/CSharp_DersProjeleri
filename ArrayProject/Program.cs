using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciSecim;
            ArrayList degerListesi = new ArrayList();

            do
            {
                Console.Clear();
                Console.WriteLine("Menü :");
                Console.WriteLine("1 - Değer ekle .");
                Console.WriteLine("2 - Değer listele .");
                Console.WriteLine("3 - Değer ara .");
                Console.WriteLine("4 - Değer Düzenle .");
                Console.WriteLine("5 - Değer Sil .");
                Console.WriteLine("6 - Uygulama çıkış .");
                Console.WriteLine("Seçiniz....");

                kullaniciSecim = Console.ReadLine();



                switch (kullaniciSecim)
                {

                    case "1":


                        Console.Write("Eklemek istediğiniz değeri giriniz ;");
                        string eklenecekdeger = Console.ReadLine();
                        degerListesi.Add(eklenecekdeger);
                        Console.WriteLine("Değeriniz başarılı bir şekilde eklendi.");
                        System.Threading.Thread.Sleep(1000);

                        break;


                    case "2":

                        for (int i = 0; i < degerListesi.Count; i++)
                        {
                            Console.WriteLine("{0}. Değer = {1}", i, degerListesi[i]);


                        }
                        Console.WriteLine("Devam etmek için bir tuşa basınız....");
                        Console.ReadLine();

                        break;

                    case "3":
                        Console.Write("Aramak istediğiniz değeri giriniz ; ");
                        string aranandeger = Console.ReadLine();

                        bool degerkontrol = degerListesi.Contains(aranandeger);

                        if (degerkontrol)
                        {
                            int indeksDegeri = degerListesi.IndexOf(aranandeger);
                            string bulunanDeger = degerListesi[indeksDegeri].ToString();

                            Console.WriteLine("{0} değeri listede {1} . indeksde mecvut.", bulunanDeger, indeksDegeri);
                            System.Threading.Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz değer bulunamadı !");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("{0} değeri listeye eklemek istermisiniz E/H ?", aranandeger);
                            string sonradaneklenecek = Console.ReadLine();

                            if (sonradaneklenecek.ToUpper() == "E")
                            {
                                degerListesi.Add(aranandeger);
                                Console.WriteLine("{0} değer listeye eklendi .", aranandeger);
                                System.Threading.Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.WriteLine("Değer listeye eklenmedi !");
                                System.Threading.Thread.Sleep(2000);
                            }

                        }

                        break;

                    case "4":

                        Console.Write("Güncellemek istediğiniz değeri giriniz ; ");
                        string degisicekDeger = Console.ReadLine();

                        Console.Write("{0} değerini hangi değer ile değiştirmek istiyorsunuz ;", degisicekDeger);
                        string yeniDeger = Console.ReadLine();

                        if (degerListesi.Contains(degisicekDeger))
                        {

                            int degisicekIndeks = degerListesi.IndexOf(degisicekDeger);

                            degerListesi[degisicekIndeks] = yeniDeger;

                            Console.WriteLine("Güncelleme başarılı ....");


                        }
                        else
                        {
                            Console.WriteLine("Değiştirmek istediğiniz değer listede bulunmuyor !");
                        }
                        System.Threading.Thread.Sleep(2000);

                        break;

                    case "5":


                        Console.Write("Tüm değerlerimi silmek istiyorsunuz  E/H ;");
                        string degerSec = Console.ReadLine();

                        if (degerSec.ToUpper() == "E")
                        {
                            degerListesi.Clear();
                            Console.WriteLine("Liste İçerisindeki tüm değerler silindi");
                        }
                        else
                        {
                            Console.Write("Liste içerisindeki silmek istedğiniz değeri giriniz ; ");
                            string silinecekDeger = Console.ReadLine();

                            if (degerListesi.Contains(silinecekDeger))
                            {
                                degerListesi.Remove(silinecekDeger);
                                Console.WriteLine("Silme işlemi başarılı ...");
                            }
                            else
                            {
                                Console.WriteLine("Silinecek değer liste içerisinde yoktur !");
                            }

                            System.Threading.Thread.Sleep(2000);


                        }
                        System.Threading.Thread.Sleep(2000);
                        break;

                    case "6":
                        break;

                    default:
                        break;
                }


            } while (kullaniciSecim != "6");


        }
    }
}
