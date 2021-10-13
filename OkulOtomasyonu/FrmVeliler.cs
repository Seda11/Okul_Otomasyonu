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
    public partial class FrmVeliler : Form
    {
        public FrmVeliler()
        {
            InitializeComponent();
        }

        dba_OkulOtomasyonuEntities db = new dba_OkulOtomasyonuEntities();

        void listele()
        {
            using(dba_OkulOtomasyonuEntities db=new dba_OkulOtomasyonuEntities()) { 
            var query = from item in db.VELI_TBL
                        select new { item.VELIID, item.VELIANNE, item.VELIBABA, item.VELITEL1, item.VELITEL2, item.VELIMAIL };
            gridControl1.DataSource = query.ToList();
            }
        }

        void temizle()
        {
            textId.Text = "";
            textAnneAd.Text = "";
            textBabaAd.Text = "";
            maskedTextBoxTel1.Text = "";
            maskedTextBoxTel2.Text = "";
            textEditMail.Text = "";
        }

        private void FrmVeliler_Load(object sender, EventArgs e)
        {
            listele();
            //gridControl1.DataSource = db.VELI_TBL.ToList();
            temizle();
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            VELI_TBL veli = new VELI_TBL();
            veli.VELIANNE = textAnneAd.Text;
            veli.VELIBABA = textBabaAd.Text;
            veli.VELITEL1 = maskedTextBoxTel1.Text;
            veli.VELITEL2 = maskedTextBoxTel2.Text;
            veli.VELIMAIL = textEditMail.Text;
            db.VELI_TBL.Add(veli);
            db.SaveChanges();
            listele();
            temizle();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            textId.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString();
            textAnneAd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIANNE").ToString();
            textBabaAd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIBABA").ToString();
            maskedTextBoxTel1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELITEL1").ToString();
            maskedTextBoxTel2.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELITEL2").ToString();
            textEditMail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIMAIL").ToString();
        }

        private void simpleButtonGüncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString());
            //var item = db.VELI_TBL.Find(id);
            //item.VELIANNE = textAnneAd.Text;
            //item.VELIBABA = textBabaAd.Text;
            //item.VELITEL1 = maskedTextBoxTel1.Text;
            //item.VELITEL2 = maskedTextBoxTel2.Text;
            //item.VELIMAIL = textEditMail.Text;
            //db.SaveChanges();
            //listele();
            //temizle();
            using(dba_OkulOtomasyonuEntities db=new dba_OkulOtomasyonuEntities())
            {
                var item = db.VELI_TBL.FirstOrDefault(x => x.VELIID == id);
                item.VELIANNE = textAnneAd.Text;
                item.VELIBABA = textBabaAd.Text;
                item.VELITEL1 = maskedTextBoxTel1.Text;
                item.VELITEL2 = maskedTextBoxTel2.Text;
                item.VELIMAIL = textEditMail.Text;
                db.SaveChanges();
                listele();
                temizle();
            }
        }

        private void simpleButtonSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VELIID").ToString());
            //var item = db.VELI_TBL.Find(id);
            //db.VELI_TBL.Remove(item);
            //db.SaveChanges();
            //listele();
            using(dba_OkulOtomasyonuEntities db=new dba_OkulOtomasyonuEntities())
            {
                var item = db.VELI_TBL.First(x => x.VELIID == id);
                db.VELI_TBL.Remove(item);
                db.SaveChanges();
                listele();
            }
        }

        private void simpleButtonTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
