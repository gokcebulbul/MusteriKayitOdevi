using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace MusteriKayitOdevi
{
    public partial class Form1 : Form
    {
        List<Kisi> kisiler = new List<Kisi>();


        public Form1()
        {
           

            InitializeComponent();
            foreach (Kisi kisi in kisiler)
            {
                kisiler.Add(kisi);
            }
        }

    
        

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();


        }
        
        private void lstKayýt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            Kisi kisi = new Kisi();
            Form2 form2 = new Form2();
            kisi.Kisi1(form2.txtAdSoyad.Text,form2.txtTelefon.Text,(int)form2.nudYas.Value,form2.txtAdres.Text);
        }
    }
}