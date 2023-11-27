using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kulaniciornek_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKullaniciOlusturun_Click(object sender, EventArgs e)
        {
            string ad=Convert.ToString(txtAd.Text);
            string soyad=Convert.ToString(txtSoyad.Text);
            string telefon=Convert.ToString(txtTelefon.Text);
            string eposta=Convert.ToString(txtEposta.Text);
            string sifre=Convert.ToString(txtSifre.Text);
            string adres = Convert.ToString(txtAdres.Text);

            Kullanici kullanici1 = new Kullanici(ad, soyad, telefon, eposta, sifre, adres);
            
            

            
        }
    }
}
