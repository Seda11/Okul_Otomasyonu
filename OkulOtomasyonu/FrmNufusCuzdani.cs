using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyonu
{
    public partial class FrmNufusCuzdani : Form
    {
        public FrmNufusCuzdani()
        {
            InitializeComponent();
        }
        public string ad, soyad, tc, cinsiyet, dogtarihi, uzanti;

        private void FrmNufusCuzdani_Load(object sender, EventArgs e)
        {
            labelControlAd.Text = ad;
            labelSoyad.Text = soyad;
            labelCinsiyet.Text = cinsiyet;
            labelTc.Text = tc;
            labelDogumTarih.Text = dogtarihi;
            pictureEdit2.Image = Image.FromFile(uzanti);

        }
    }
}
