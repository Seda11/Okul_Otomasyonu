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
    public partial class FrmOgretmenler : Form
    {
        public FrmOgretmenler()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from OGRT_TBL", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

     
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

        void bransgetir()
        {
            SqlCommand komut = new SqlCommand("Select * from BRANS_TBL", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEditBrans.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        void temizle()
        {
            textId.Text = "";
            textAd.Text = "";
            textSoyad.Text = "";
            maskedTextBoxTc.Text = "";
            maskedTextBoxTel.Text = "";
            comboBoxEditIl.Text = "";
            comboBoxEditIlce.Text = "";
            comboBoxEditBrans.Text = "";
            textEditMail.Text = "";
            richTextBoxAdress.Text = "";
            pictureBox1.ImageLocation = "";
        }

        private void FrmOgretmenler_Load(object sender, EventArgs e)
        {
            listele();
            ilekle();
            bransgetir();
        }

        private void comboBoxEditIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEditIlce.Properties.Items.Clear();
            comboBoxEditIlce.Text = "";


            SqlCommand komut = new SqlCommand("Select * from ILCE_TBL where sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxEditIl.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEditIlce.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();

        }
        public string yeniyol;
        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into OGRT_TBL (OGRTAD, OGRTSOYAD,OGRTTC,OGRTTEL,OGRTMAIL,OGRTIL,OGRTILCE,OGRTADRES,OGRTBRANS,OGRTFOTO) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textAd.Text);
            komut.Parameters.AddWithValue("@p2", textSoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBoxTc.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBoxTel.Text);
            komut.Parameters.AddWithValue("@p5", textEditMail.Text);
            komut.Parameters.AddWithValue("@p6", comboBoxEditIl.Text);
            komut.Parameters.AddWithValue("@p7", comboBoxEditIlce.Text);
            komut.Parameters.AddWithValue("@p8", richTextBoxAdress.Text);
            komut.Parameters.AddWithValue("@p9", comboBoxEditBrans.Text);
            komut.Parameters.AddWithValue("@p10",Path.GetFileName(yeniyol));

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textId.Text = dr["OGRTID"].ToString();
                textAd.Text = dr["OGRTAD"].ToString();
                textSoyad.Text = dr["OGRTSOYAD"].ToString();
                maskedTextBoxTc.Text = dr["OGRTTC"].ToString();
                maskedTextBoxTel.Text = dr["OGRTTEL"].ToString();
                comboBoxEditIl.Text = dr["OGRTIL"].ToString();
                comboBoxEditIlce.Text = dr["OGRTILCE"].ToString();
                comboBoxEditBrans.Text = dr["OGRTBRANS"].ToString();
                textEditMail.Text = dr["OGRTMAIL"].ToString();
                richTextBoxAdress.Text = dr["OGRTADRES"].ToString();
                yeniyol = "C:\\Users\\ARGE\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler\\" + dr["OGRTFOTO"].ToString();
                pictureBox1.ImageLocation = yeniyol;

            }

        }

        
        private void simpleButtonResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*png;*nef;*jfif; | Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\ARGE\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu, yeniyol);
            pictureBox1.ImageLocation = yeniyol;
        }

        private void simpleButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update OGRT_TBL set OGRTAD=@p1, OGRTSOYAD=@p2,OGRTTC=@p3,OGRTTEL=@p4,OGRTMAIL=@p5,OGRTIL=@p6,OGRTILCE=@p7,OGRTADRES=@p8,OGRTBRANS=@p9,OGRTFOTO=@p10 where OGRTID=@p11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textAd.Text);
            komut.Parameters.AddWithValue("@p2", textSoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBoxTc.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBoxTel.Text);
            komut.Parameters.AddWithValue("@p5", textEditMail.Text);
            komut.Parameters.AddWithValue("@p6", comboBoxEditIl.Text);
            komut.Parameters.AddWithValue("@p7", comboBoxEditIlce.Text);
            komut.Parameters.AddWithValue("@p8", richTextBoxAdress.Text);
            komut.Parameters.AddWithValue("@p9", comboBoxEditBrans.Text);
            komut.Parameters.AddWithValue("@p10", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p11", textId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();


        }

        private void simpleButtonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from OGRT_TBL where OGRTID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void simpleButtonTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
