using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriKayitOdevi
{
    public partial class Form2 : Form
    {
        List<Kisi> kisiler = new List<Kisi>();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi kisi = new Kisi();
            kisi.AdSoyad = txtAdSoyad.Text;
            kisi.Telefon = txtTelefon.Text;
            kisi.Adres = txtAdres.Text;
            kisi.Yas = (int)nudYas.Value;

            kisiler.Add(kisi);

            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            nudYas.Value = 0;
        }

        private void btnListeyeDon_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            foreach (Kisi kisi in kisiler)
            {
                form1.lstKayıt.Items.Add($"{kisi.AdSoyad}");
            }
            form1.Show();
        }
    }
}
