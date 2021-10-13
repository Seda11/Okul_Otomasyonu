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
    public partial class FrmOgrenciler : Form
    {
        public FrmOgrenciler()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        void listele()
        {
            //5.Sınıf-Select * from OGR_TBL where OGRSINIF='5.SINIF
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Execute OgrenciVeli5", bgl.baglanti());
            da1.Fill(dt1);
            gridControl1.DataSource = dt1;

            //6.Sınıf
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Execute OgrenciVeli6", bgl.baglanti());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;

            //7.Sınıf
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Execute OgrenciVeli7", bgl.baglanti());
            da3.Fill(dt3);
            gridControl3.DataSource = dt3;

            //8.Sınıf
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Execute OgrenciVeli8", bgl.baglanti());
            da4.Fill(dt4);
            gridControl4.DataSource = dt4;
        }

        void velilistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select VELIID,(VELIANNE+'  |  '+VELIBABA) as 'VELI ANNE BABA' from VELI_TBL",bgl.baglanti());
            da.Fill(dt);
            lookUpEditVeli.Properties.ValueMember = "VELIID";
            lookUpEditVeli.Properties.DisplayMember = "VELI ANNE BABA";
            lookUpEditVeli.Properties.DataSource = dt;
        }

        void ilekle()
        {
            SqlCommand komut = new SqlCommand("Select * from IL_TBL", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEditIl.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        void temizle()
        {
            textId.Text = "";
            textAd.Text = "";
            textSoyad.Text = "";
            maskedTextBoxOgrNo.Text = "";
            maskedTextBoxTc.Text = "";
            radioButtonErkek.Checked = false;
            radioButtonKız.Checked = false;
            comboBoxEditSinif.Text = "";
            comboBoxEditIl.Text = "";
            comboBoxEditIlce.Text = "";
            dateEditDogumTarih.Text = "";
            richTextBoxAdress.Text = "";
            pictureEdit1.Text = "";
        }
        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            listele();
            ilekle();
            temizle();
            velilistesi();
        }

        private void comboBoxEditIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEditIlce.Properties.Items.Clear();
            comboBoxEditIlce.Text = "";

            SqlCommand komut = new SqlCommand("Select * from ILCE_TBL where sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxEditIl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEditIlce.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                textId.Text = dr["OGRID"].ToString();
                textAd.Text = dr["OGRAD"].ToString();
                textSoyad.Text = dr["OGRSOYAD"].ToString();
                maskedTextBoxTc.Text = dr["OGRTC"].ToString();
                //maskedTextBoxOgrNo.Text = dr["OGRNO"].ToString();
                comboBoxEditSinif.Text = dr["OGRSINIF"].ToString();
                if(dr["OGRCINSIYET"].ToString()=="E")
                {
                    radioButtonErkek.Checked = true;
                }
                else
                {
                    radioButtonKız.Checked = true;
                }
                comboBoxEditIl.Text = dr["OGRIL"].ToString();
                comboBoxEditIlce.Text = dr["OGRILCE"].ToString();
                dateEditDogumTarih.Text = dr["OGRDOGTAR"].ToString();
                richTextBoxAdress.Text = dr["OGRADRES"].ToString();
                lookUpEditVeli.Text = dr["VELIANNEBABA"].ToString();
                yeniyol = "C:\\Users\\ARGE\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                
            }
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if (dr != null)
            {
                textId.Text = dr["OGRID"].ToString();
                textAd.Text = dr["OGRAD"].ToString();
                textSoyad.Text = dr["OGRSOYAD"].ToString();
                maskedTextBoxTc.Text = dr["OGRTC"].ToString();
                //maskedTextBoxOgrNo.Text = dr["OGRNO"].ToString();
                comboBoxEditSinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    radioButtonErkek.Checked = true;
                }
                else
                {
                    radioButtonKız.Checked = true;
                }
                comboBoxEditIl.Text = dr["OGRIL"].ToString();
                comboBoxEditIlce.Text = dr["OGRILCE"].ToString();
                dateEditDogumTarih.Text = dr["OGRDOGTAR"].ToString();
                richTextBoxAdress.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\ARGE\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                lookUpEditVeli.Text =dr["VELIANNEBABA"].ToString();
            }
        }

        private void gridView3_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);

            if (dr != null)
            {
                textId.Text = dr["OGRID"].ToString();
                textAd.Text = dr["OGRAD"].ToString();
                textSoyad.Text = dr["OGRSOYAD"].ToString();
                maskedTextBoxTc.Text = dr["OGRTC"].ToString();
                //maskedTextBoxOgrNo.Text = dr["OGRNO"].ToString();
                comboBoxEditSinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    radioButtonErkek.Checked = true;
                }
                else
                {
                    radioButtonKız.Checked = true;
                }
                comboBoxEditIl.Text = dr["OGRIL"].ToString();
                comboBoxEditIlce.Text = dr["OGRILCE"].ToString();
                dateEditDogumTarih.Text = dr["OGRDOGTAR"].ToString();
                richTextBoxAdress.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\ARGE\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                lookUpEditVeli.Text =dr["VELIANNEBABA"].ToString();
            }
        }

        private void gridView4_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);

            if (dr != null)
            {
                textId.Text = dr["OGRID"].ToString();
                textAd.Text = dr["OGRAD"].ToString();
                textSoyad.Text = dr["OGRSOYAD"].ToString();
                maskedTextBoxTc.Text = dr["OGRTC"].ToString();
                //maskedTextBoxOgrNo.Text = dr["OGRNO"].ToString();
                comboBoxEditSinif.Text = dr["OGRSINIF"].ToString();
                if (dr["OGRCINSIYET"].ToString() == "E")
                {
                    radioButtonErkek.Checked = true;
                }
                else
                {
                    radioButtonKız.Checked = true;
                }
                comboBoxEditIl.Text = dr["OGRIL"].ToString();
                comboBoxEditIlce.Text = dr["OGRILCE"].ToString();
                dateEditDogumTarih.Text = dr["OGRDOGTAR"].ToString();
                richTextBoxAdress.Text = dr["OGRADRES"].ToString();
                yeniyol = "C:\\Users\\ARGE\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler\\" + dr["OGRFOTO"].ToString();
                pictureEdit1.Image = Image.FromFile(yeniyol);
                lookUpEditVeli.SelectedText = dr["VELIANNEBABA"].ToString();
            }
          
        }
        public string cinsiyet;
        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into OGR_TBL (OGRAD,OGRSOYAD,OGRNO,OGRSINIF,OGRDOGTAR,OGRCINSIYET,OGRTC,OGRIL,OGRILCE,OGRADRES,OGRFOTO,OGRVELIID) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textAd.Text);
            komut.Parameters.AddWithValue("@p2", textSoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBoxOgrNo.Text);
            komut.Parameters.AddWithValue("@p4", comboBoxEditSinif.Text);
            komut.Parameters.AddWithValue("@p5", dateEditDogumTarih.Text);
            if (radioButtonErkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet = "E");
            }
            else
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet = "K");
            }
            komut.Parameters.AddWithValue("@p7", maskedTextBoxTc.Text);
            komut.Parameters.AddWithValue("@p8", comboBoxEditIl.Text);
            komut.Parameters.AddWithValue("@p9", comboBoxEditIlce.Text);
            komut.Parameters.AddWithValue("@p10", richTextBoxAdress.Text);
            komut.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p12", lookUpEditVeli.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        public string yeniyol;
        private void simpleButtonResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.png;*.nef;*.jfif; | Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\ARGE\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu, yeniyol);
            pictureEdit1.Image = Image.FromFile(yeniyol);
        }

        private void simpleButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update OGR_TBL set OGRAD=@p1,OGRSOYAD=@p2,OGRNO=@p3,OGRSINIF=@p4,OGRDOGTAR=@p5,OGRCINSIYET=@p6,OGRTC=@p7,OGRIL=@p8,OGRILCE=@p9,OGRADRES=@p10,OGRFOTO=@p11, OGRVELIID=@p12 where OGRID=@p12", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textAd.Text);
            komut.Parameters.AddWithValue("@p2", textSoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBoxOgrNo.Text);
            komut.Parameters.AddWithValue("@p4", comboBoxEditSinif.Text);
            komut.Parameters.AddWithValue("@p5", dateEditDogumTarih.Text);
            if (radioButtonErkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet = "E");
            }
            else
            {
                komut.Parameters.AddWithValue("@p6", cinsiyet = "K");
            }
            komut.Parameters.AddWithValue("@p7", maskedTextBoxTc.Text);
            komut.Parameters.AddWithValue("@p8", comboBoxEditIl.Text);
            komut.Parameters.AddWithValue("@p9", comboBoxEditIlce.Text);
            komut.Parameters.AddWithValue("@p10", richTextBoxAdress.Text);
            komut.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p12", textId.Text);
            komut.Parameters.AddWithValue("@p13", lookUpEditVeli.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void simpleButtonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from OGR_TBL where OGRID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Bilgileri Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void simpleButtonTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            FrmNufusCuzdani frm = new FrmNufusCuzdani();

            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.tc = dr["OGRTC"].ToString();
                frm.cinsiyet = dr["OGRCINSIYET"].ToString();
                frm.dogtarihi = dr["OGRDOGTAR"].ToString();
                frm.uzanti="C:\\Users\\ARGE\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            FrmNufusCuzdani frm = new FrmNufusCuzdani();

            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.tc = dr["OGRTC"].ToString();
                frm.cinsiyet = dr["OGRCINSIYET"].ToString();
                frm.dogtarihi = dr["OGRDOGTAR"].ToString();
                frm.uzanti = "C:\\Users\\ARGE\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            FrmNufusCuzdani frm = new FrmNufusCuzdani();

            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.tc = dr["OGRTC"].ToString();
                frm.cinsiyet = dr["OGRCINSIYET"].ToString();
                frm.dogtarihi = dr["OGRDOGTAR"].ToString();
                frm.uzanti = "C:\\Users\\ARGE\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }

        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            FrmNufusCuzdani frm = new FrmNufusCuzdani();

            if (dr != null)
            {
                frm.ad = dr["OGRAD"].ToString();
                frm.soyad = dr["OGRSOYAD"].ToString();
                frm.tc = dr["OGRTC"].ToString();
                frm.cinsiyet = dr["OGRCINSIYET"].ToString();
                frm.dogtarihi = dr["OGRDOGTAR"].ToString();
                frm.uzanti = "C:\\Users\\ARGE\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler\\" + dr["OGRFOTO"].ToString();
            }
            frm.Show();
        }
    }
}
