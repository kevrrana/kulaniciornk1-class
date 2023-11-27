using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulaniciornek_class
{
    internal class Kullanici
    {
        string ad;
        string soyad;
        string telefon;
        string eposta;
        string sifre;
        string adres;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Eposta { get => eposta; set => eposta = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public string Adres { get => adres; set => adres = value; }

        public Kullanici(string ad, string soyad, string telefon, string eposta, string sifre, string adres)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.telefon = telefon;
            this.eposta = eposta;
            this.sifre = sifre;
            this.adres = adres;
        }
    }
}
