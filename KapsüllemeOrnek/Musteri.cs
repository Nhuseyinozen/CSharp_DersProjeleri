using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsüllemeOrnek
{
    internal class Musteri
    {

        private string tckimliknümarasi;

        public string TCKimlikNümarasi
        {
             get
            {

                return tckimliknümarasi.Substring(0,3);
            }
            set
            {

                if (value.Length == 11)
                {

                    bool bayrak = false;

                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if (karakterKontrol)
                        {
                            // Sayısal karakter.
                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }

                    }
                    if (bayrak) 
                    {
                        Console.WriteLine("Tc kimlik numarası içindeki değerler sayısal olmalıdır !");

                    }
                    else { tckimliknümarasi = value; }




                }
                else
                {
                    Console.WriteLine("TC kimlik numarası 11 haneden oluşmalıdır");
                }




            }
        }

    }
}
