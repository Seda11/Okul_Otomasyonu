
namespace OkulOtomasyonu
{
    partial class FrmAnaModül
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaModül));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAnaSayfa = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItemOgretmen = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOgrenci = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemVeli = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemNot = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemKarne = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemİstatistik = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDavranis = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRehber = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemGiderler = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemKasa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRapor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemN = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAyar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemWeb = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItemAnaSayfa,
            this.barButtonItemOgretmen,
            this.barButtonItemOgrenci,
            this.barButtonItemVeli,
            this.barButtonItemNot,
            this.barButtonItemKarne,
            this.barButtonItemİstatistik,
            this.barButtonItemDavranis,
            this.barButtonItemRehber,
            this.barButtonItemGiderler,
            this.barButtonItemKasa,
            this.barButtonItemRapor,
            this.barButtonItemN,
            this.barButtonItemAyar,
            this.barButtonItemWeb});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1362, 150);
            // 
            // barButtonItemAnaSayfa
            // 
            this.barButtonItemAnaSayfa.ActAsDropDown = true;
            this.barButtonItemAnaSayfa.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItemAnaSayfa.Caption = "AnaSayfa";
            this.barButtonItemAnaSayfa.DropDownControl = this.popupMenu1;
            this.barButtonItemAnaSayfa.Id = 1;
            this.barButtonItemAnaSayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemAnaSayfa.ImageOptions.Image")));
            this.barButtonItemAnaSayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemAnaSayfa.ImageOptions.LargeImage")));
            this.barButtonItemAnaSayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItemAnaSayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItemAnaSayfa.Name = "barButtonItemAnaSayfa";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // barButtonItemOgretmen
            // 
            this.barButtonItemOgretmen.Caption = "Öğretmen";
            this.barButtonItemOgretmen.Id = 2;
            this.barButtonItemOgretmen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemOgretmen.ImageOptions.Image")));
            this.barButtonItemOgretmen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemOgretmen.ImageOptions.LargeImage")));
            this.barButtonItemOgretmen.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItemOgretmen.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItemOgretmen.Name = "barButtonItemOgretmen";
            this.barButtonItemOgretmen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOgretmen_ItemClick);
            // 
            // barButtonItemOgrenci
            // 
            this.barButtonItemOgrenci.Caption = "Öğrenci";
            this.barButtonItemOgrenci.Id = 3;
            this.barButtonItemOgrenci.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemOgrenci.ImageOptions.Image")));
            this.barButtonItemOgrenci.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemOgrenci.ImageOptions.LargeImage")));
            this.barButtonItemOgrenci.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItemOgrenci.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItemOgrenci.Name = "barButtonItemOgrenci";
            this.barButtonItemOgrenci.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOgrenci_ItemClick);
            // 
            // barButtonItemVeli
            // 
            this.barButtonItemVeli.Caption = "VELİ";
            this.barButtonItemVeli.Id = 4;
            this.barButtonItemVeli.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemVeli.ImageOptions.Image")));
            this.barButtonItemVeli.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemVeli.ImageOptions.LargeImage")));
            this.barButtonItemVeli.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItemVeli.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItemVeli.Name = "barButtonItemVeli";
            this.barButtonItemVeli.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemVeli_ItemClick);
            // 
            // barButtonItemNot
            // 
            this.barButtonItemNot.Caption = "NOT GİRİŞ";
            this.barButtonItemNot.Id = 5;
            this.barButtonItemNot.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemNot.ImageOptions.Image")));
            this.barButtonItemNot.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemNot.ImageOptions.LargeImage")));
            this.barButtonItemNot.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItemNot.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItemNot.Name = "barButtonItemNot";
            // 
            // barButtonItemKarne
            // 
            this.barButtonItemKarne.Caption = "KARNE";
            this.barButtonItemKarne.Id = 6;
            this.barButtonItemKarne.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemKarne.ImageOptions.Image")));
            this.barButtonItemKarne.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemKarne.ImageOptions.LargeImage")));
            this.barButtonItemKarne.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItemKarne.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItemKarne.Name = "barButtonItemKarne";
            // 
            // barButtonItemİstatistik
            // 
            this.barButtonItemİstatistik.Caption = "İSTATİSTİKLER";
            this.barButtonItemİstatistik.Id = 7;
            this.barButtonItemİstatistik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemİstatistik.ImageOptions.Image")));
            this.barButtonItemİstatistik.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemİstatistik.ImageOptions.LargeImage")));
            this.barButtonItemİstatistik.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItemİstatistik.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItemİstatistik.Name = "barButtonItemİstatistik";
            // 
            // barButtonItemDavranis
            // 
            this.barButtonItemDavranis.Caption = "DAVRANIŞ";
            this.barButtonItemDavranis.Id = 8;
            this.barButtonItemDavranis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemDavranis.ImageOptions.Image")));
            this.barButtonItemDavranis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemDavranis.ImageOptions.LargeImage")));
            this.barButtonItemDavranis.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItemDavranis.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItemDavranis.Name = "barButtonItemDavranis";
            // 
            // barButtonItemRehber
            // 
            this.barButtonItemRehber.Caption = "REHBER";
            this.barButtonItemRehber.Id = 9;
            this.barButtonItemRehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemRehber.ImageOptions.Image")));
            this.barButtonItemRehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemRehber.ImageOptions.LargeImage")));
            this.barButtonItemRehber.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItemRehber.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItemRehber.Name = "barButtonItemRehber";
            // 
            // barButtonItemGiderler
            // 
            this.barButtonItemGiderler.Caption = "GİDERLER";
            this.barButtonItemGiderler.Id = 10;
            this.barButtonItemGiderler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemGiderler.ImageOptions.Image")));
            this.barButtonItemGiderler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemGiderler.ImageOptions.LargeImage")));
            this.barButtonItemGiderler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItemGiderler.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItemGiderler.Name = "barButtonItemGiderler";
            // 
            // barButtonItemKasa
            // 
            this.barButtonItemKasa.Caption = "KASA";
            this.barButtonItemKasa.Id = 11;
            this.barButtonItemKasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemKasa.ImageOptions.Image")));
            this.barButtonItemKasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemKasa.ImageOptions.LargeImage")));
            this.barButtonItemKasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItemKasa.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItemKasa.Name = "barButtonItemKasa";
            // 
            // barButtonItemRapor
            // 
            this.barButtonItemRapor.Caption = "RAPORLAR";
            this.barButtonItemRapor.Id = 12;
            this.barButtonItemRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemRapor.ImageOptions.Image")));
            this.barButtonItemRapor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemRapor.ImageOptions.LargeImage")));
            this.barButtonItemRapor.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItemRapor.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItemRapor.Name = "barButtonItemRapor";
            // 
            // barButtonItemN
            // 
            this.barButtonItemN.Caption = "NOTLAR";
            this.barButtonItemN.Id = 13;
            this.barButtonItemN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemN.ImageOptions.Image")));
            this.barButtonItemN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemN.ImageOptions.LargeImage")));
            this.barButtonItemN.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItemN.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItemN.Name = "barButtonItemN";
            // 
            // barButtonItemAyar
            // 
            this.barButtonItemAyar.Caption = "AYARALAR";
            this.barButtonItemAyar.Id = 14;
            this.barButtonItemAyar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemAyar.ImageOptions.Image")));
            this.barButtonItemAyar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemAyar.ImageOptions.LargeImage")));
            this.barButtonItemAyar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItemAyar.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItemAyar.Name = "barButtonItemAyar";
            this.barButtonItemAyar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAyar_ItemClick);
            // 
            // barButtonItemWeb
            // 
            this.barButtonItemWeb.Caption = "WEB SAYFA";
            this.barButtonItemWeb.Id = 15;
            this.barButtonItemWeb.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemWeb.ImageOptions.Image")));
            this.barButtonItemWeb.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemWeb.ImageOptions.LargeImage")));
            this.barButtonItemWeb.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItemWeb.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItemWeb.Name = "barButtonItemWeb";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Okul Yönetim Sistemi";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemAnaSayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemOgretmen);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemOgrenci);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemVeli);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemNot);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemKarne);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemİstatistik);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDavranis);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemRehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemGiderler);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemKasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemRapor);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemN);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemAyar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemWeb);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmAnaModül
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 691);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmAnaModül";
            this.Text = "A Okulu";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAnaSayfa;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOgretmen;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOgrenci;
        private DevExpress.XtraBars.BarButtonItem barButtonItemVeli;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNot;
        private DevExpress.XtraBars.BarButtonItem barButtonItemKarne;
        private DevExpress.XtraBars.BarButtonItem barButtonItemİstatistik;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDavranis;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRehber;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGiderler;
        private DevExpress.XtraBars.BarButtonItem barButtonItemKasa;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRapor;
        private DevExpress.XtraBars.BarButtonItem barButtonItemN;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAyar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemWeb;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

