using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace OkulOtomasyonu
{
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        //ADO.NET -- Öğretmenler
        //Entity Freamwork- Database first -- Öğrenciler

        sqlBaglantisi bgl = new sqlBaglantisi();  //adonet için
        dba_OkulOtomasyonuEntities db = new dba_OkulOtomasyonuEntities();  //entity freamwork için

        //ADO.NET ÖğretmeN şifre bilgileri
        void listele()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Execute AyarlarOgretmenler", bgl.baglanti());
            da1.Fill(dt1);
            gridControl1.DataSource = dt1;
        }
        //Entity Freamwork Ogrenci Listele
        void ogrListele()
        {
            gridControl2.DataSource = db.AyarlarOgrenciler();
        }

        // ADO:NET LookUpEdit Aracı Veri Getirme
        void ogretmenlistesi()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select OGRTID,(OGRTAD+' '+OGRTSOYAD) as 'OGRTADSOYAD',OGRTBRANS from OGRT_TBL", bgl.baglanti());
            da2.Fill(dt2);
            lookUpEditOgrtAd.Properties.ValueMember = "OGRTID";
            lookUpEditOgrtAd.Properties.DisplayMember = "OGRTADSOYAD";
            lookUpEditOgrtAd.Properties.NullText = "Öğretmen Seçiniz";
            lookUpEditOgrtAd.Properties.DataSource = dt2;
        }
        //Entity Freamwork ile LookUpEdit Veri Getirme
        void ogrenciListesi()
        {
            var deger = from item in db.OGR_TBL
                        select new
                        {
                            OGRID = item.OGRID,
                            OGRSOYAD = item.OGRAD + " " + item.OGRSOYAD,
                            OGRSINIF = item.OGRSINIF,
                        };
            lookUpEditOAd.Properties.ValueMember = "OGRID";
            lookUpEditOAd.Properties.DisplayMember = "OGRSOYAD";

            lookUpEditOAd.Properties.NullText = "Öğrenci Seçiniz";
            lookUpEditOAd.Properties.DataSource = deger.ToList();
        }
        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            ogretmenlistesi();
            ogrListele();
            ogrenciListesi();
        }

        //ADO:NET ile girdcontrol verilerini araçlara taşımak

        public string yeniyol;
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textOgrtId.Text = dr["AYARLARID"].ToString();
                lookUpEditOgrtAd.Text = dr["OGRTADSOYAD"].ToString();
                textBrans.Text = dr["OGRTBRANS"].ToString();
                textOgrTc.Text = dr["OGRTTC"].ToString();
                textSifre.Text = dr["OGRTSIFRE"].ToString();
                yeniyol = "C:\\Users\\ARGE\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler\\" + dr["OGRTFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }
        }
        //ADO:NET LookUpEdit Seçimi Sonrası Verilerin Düzeltilmesi

        private void lookUpEditOgrtAd_Properties_EditValueChanged(object sender, EventArgs e)
        {
            textOgrSifre.Text = "";
            SqlCommand komut = new SqlCommand("Select * from OGRT_TBL where OGRTID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lookUpEditOgrtAd.ItemIndex + 1);
            SqlDataReader dr3 = komut.ExecuteReader();
            while (dr3.Read())
            {
                textOgrId.Text = dr3["OGRTID"].ToString();
                textBrans.Text = dr3["OGRTBRANS"].ToString();
                textOgrTc.Text = dr3["OGRTTC"].ToString();
                yeniyol = "C:\\Users\\ARGE\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler\\" + dr3["OGRTFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
            }
            bgl.baglanti().Close();
        }


    }
}
