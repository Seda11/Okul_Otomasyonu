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
    public partial class FrmAnaModül : Form
    {
        public FrmAnaModül()
        {
            InitializeComponent();
        }

        FrmOgretmenler frm1;
        FrmOgrenciler frm2;
        FrmVeliler frm3;
        FrmAyarlar frm4;
        private void barButtonItemOgretmen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null|| frm1.IsDisposed)
            {
                frm1 = new FrmOgretmenler();
                frm1.MdiParent = this;
                frm1.Show();
            }
        }

        private void barButtonItemOgrenci_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new FrmOgrenciler();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        private void barButtonItemVeli_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new FrmVeliler();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        private void barButtonItemAyar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new FrmAyarlar();
                frm4.MdiParent = this;
                frm4.Show();
                
            }
        }
    }
}
