using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriKayitOdevi
{
    internal class Kisi : Form
    {
        public void Kisi1(string adsoyad,string tel,int yas,string adres)
        {
            List<Kisi> kisiler = new List<Kisi>();
           Form1 form1 = new Form1();
           
            form1.lstKayıt.SelectedIndex=0;

            AdSoyad = adsoyad;
            Telefon = tel;
            Yas = yas;
            Adres = adres;
            string info = $"Ad Soyad : {AdSoyad}\n" + $"Telefon : {Telefon}\n" + $"Yaş : {Yas}\n" + $"Adres : {Adres}";
            Console.WriteLine(info);
        }
        public string AdSoyad { get; set; }

        public string Telefon { get; set; }

        public string Adres { get; set; }

        public int Yas { get; set; }
    }
}
