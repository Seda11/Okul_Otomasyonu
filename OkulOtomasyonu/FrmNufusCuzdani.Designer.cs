
namespace OkulOtomasyonu
{
    partial class FrmNufusCuzdani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTc = new DevExpress.XtraEditors.LabelControl();
            this.labelSoyad = new DevExpress.XtraEditors.LabelControl();
            this.labelControlAd = new DevExpress.XtraEditors.LabelControl();
            this.labelDogumTarih = new DevExpress.XtraEditors.LabelControl();
            this.labelCinsiyet = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTc
            // 
            this.labelTc.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTc.Appearance.Options.UseFont = true;
            this.labelTc.Location = new System.Drawing.Point(29, 81);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(0, 16);
            this.labelTc.TabIndex = 0;
            // 
            // labelSoyad
            // 
            this.labelSoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyad.Appearance.Options.UseFont = true;
            this.labelSoyad.Location = new System.Drawing.Point(178, 112);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(0, 16);
            this.labelSoyad.TabIndex = 1;
            // 
            // labelControlAd
            // 
            this.labelControlAd.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControlAd.Appearance.Options.UseFont = true;
            this.labelControlAd.Location = new System.Drawing.Point(178, 143);
            this.labelControlAd.Name = "labelControlAd";
            this.labelControlAd.Size = new System.Drawing.Size(0, 16);
            this.labelControlAd.TabIndex = 2;
            // 
            // labelDogumTarih
            // 
            this.labelDogumTarih.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDogumTarih.Appearance.Options.UseFont = true;
            this.labelDogumTarih.Location = new System.Drawing.Point(178, 175);
            this.labelDogumTarih.Name = "labelDogumTarih";
            this.labelDogumTarih.Size = new System.Drawing.Size(0, 16);
            this.labelDogumTarih.TabIndex = 3;
            // 
            // labelCinsiyet
            // 
            this.labelCinsiyet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCinsiyet.Appearance.Options.UseFont = true;
            this.labelCinsiyet.Location = new System.Drawing.Point(339, 175);
            this.labelCinsiyet.Name = "labelCinsiyet";
            this.labelCinsiyet.Size = new System.Drawing.Size(0, 16);
            this.labelCinsiyet.TabIndex = 4;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Location = new System.Drawing.Point(29, 112);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(123, 132);
            this.pictureEdit2.TabIndex = 19;
            // 
            // FrmNufusCuzdani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::OkulOtomasyonu.Properties.Resources.kimlikKarti1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 284);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.labelCinsiyet);
            this.Controls.Add(this.labelDogumTarih);
            this.Controls.Add(this.labelControlAd);
            this.Controls.Add(this.labelSoyad);
            this.Controls.Add(this.labelTc);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FrmNufusCuzdani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNufusCuzdani";
            this.Load += new System.EventHandler(this.FrmNufusCuzdani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelTc;
        private DevExpress.XtraEditors.LabelControl labelSoyad;
        private DevExpress.XtraEditors.LabelControl labelControlAd;
        private DevExpress.XtraEditors.LabelControl labelDogumTarih;
        private DevExpress.XtraEditors.LabelControl labelCinsiyet;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}