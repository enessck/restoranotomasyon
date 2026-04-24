namespace RestaurantOtomasyon
{
    partial class SatisRaporlariForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSatislar;
        
        // Paneller
        private System.Windows.Forms.Panel pnlKategoriler;
        private System.Windows.Forms.Panel pnlGrafik;

        // Kategori Butonları
        private System.Windows.Forms.Button btnCatAnayemek;
        private System.Windows.Forms.Button btnCatIcecekler;
        private System.Windows.Forms.Button btnCatTatlilar;
        private System.Windows.Forms.Button btnCatSalata;
        private System.Windows.Forms.Button btnCatFastfood;
        private System.Windows.Forms.Button btnCatCorba;
        private System.Windows.Forms.Button btnCatMakarna;
        private System.Windows.Forms.Button btnCatArasicak;
        private System.Windows.Forms.Button btnCatTumUrunler;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            pnlKategoriler = new Panel();
            btnCatAnayemek = new Button();
            btnCatIcecekler = new Button();
            btnCatTatlilar = new Button();
            btnCatSalata = new Button();
            btnCatFastfood = new Button();
            btnCatCorba = new Button();
            btnCatMakarna = new Button();
            btnCatArasicak = new Button();
            btnCatTumUrunler = new Button();
            pnlGrafik = new Panel();
            pnlKategoriler.SuspendLayout();
            SuspendLayout();
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(-500, -500);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(200, 27);
            dtpBaslangic.TabIndex = 100;
            dtpBaslangic.Visible = false;
            dtpBaslangic.ValueChanged += dtpTarih_ValueChanged;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(-500, -500);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(200, 27);
            dtpBitis.TabIndex = 101;
            dtpBitis.Visible = false;
            dtpBitis.ValueChanged += dtpTarih_ValueChanged;
            // 
            // pnlKategoriler
            // 
            pnlKategoriler.BackColor = Color.FromArgb(255, 224, 192);
            pnlKategoriler.BorderStyle = BorderStyle.FixedSingle;
            pnlKategoriler.Controls.Add(btnCatAnayemek);
            pnlKategoriler.Controls.Add(btnCatIcecekler);
            pnlKategoriler.Controls.Add(btnCatTatlilar);
            pnlKategoriler.Controls.Add(btnCatSalata);
            pnlKategoriler.Controls.Add(btnCatFastfood);
            pnlKategoriler.Controls.Add(btnCatCorba);
            pnlKategoriler.Controls.Add(btnCatMakarna);
            pnlKategoriler.Controls.Add(btnCatArasicak);
            pnlKategoriler.Controls.Add(btnCatTumUrunler);
            pnlKategoriler.Location = new Point(14, 14);
            pnlKategoriler.Name = "pnlKategoriler";
            pnlKategoriler.Size = new Size(300, 472);
            pnlKategoriler.TabIndex = 0;
            // 
            // btnCatAnayemek
            // 
            btnCatAnayemek.BackColor = Color.FromArgb(255, 192, 192);
            btnCatAnayemek.FlatAppearance.BorderSize = 0;
            btnCatAnayemek.FlatStyle = FlatStyle.Flat;
            btnCatAnayemek.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCatAnayemek.ForeColor = Color.Black;
            btnCatAnayemek.Location = new Point(5, 5);
            btnCatAnayemek.Name = "btnCatAnayemek";
            btnCatAnayemek.Size = new Size(140, 90);
            btnCatAnayemek.TabIndex = 0;
            btnCatAnayemek.Tag = "ANAYEMEK";
            btnCatAnayemek.Text = "Ana Yemek";
            btnCatAnayemek.UseVisualStyleBackColor = false;
            btnCatAnayemek.Click += KategoriButon_Click;
            // 
            // btnCatIcecekler
            // 
            btnCatIcecekler.BackColor = Color.FromArgb(0, 192, 192);
            btnCatIcecekler.FlatAppearance.BorderSize = 0;
            btnCatIcecekler.FlatStyle = FlatStyle.Flat;
            btnCatIcecekler.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCatIcecekler.ForeColor = Color.Black;
            btnCatIcecekler.Location = new Point(150, 5);
            btnCatIcecekler.Name = "btnCatIcecekler";
            btnCatIcecekler.Size = new Size(140, 90);
            btnCatIcecekler.TabIndex = 1;
            btnCatIcecekler.Tag = "İÇECEKLER";
            btnCatIcecekler.Text = "İçecekler";
            btnCatIcecekler.UseVisualStyleBackColor = false;
            btnCatIcecekler.Click += KategoriButon_Click;
            // 
            // btnCatTatlilar
            // 
            btnCatTatlilar.BackColor = Color.FromArgb(255, 128, 0);
            btnCatTatlilar.FlatAppearance.BorderSize = 0;
            btnCatTatlilar.FlatStyle = FlatStyle.Flat;
            btnCatTatlilar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCatTatlilar.ForeColor = Color.Black;
            btnCatTatlilar.Location = new Point(5, 100);
            btnCatTatlilar.Name = "btnCatTatlilar";
            btnCatTatlilar.Size = new Size(140, 90);
            btnCatTatlilar.TabIndex = 2;
            btnCatTatlilar.Tag = "TATLILAR";
            btnCatTatlilar.Text = "Tatlılar";
            btnCatTatlilar.UseVisualStyleBackColor = false;
            btnCatTatlilar.Click += KategoriButon_Click;
            // 
            // btnCatSalata
            // 
            btnCatSalata.BackColor = Color.FromArgb(128, 128, 255);
            btnCatSalata.FlatAppearance.BorderSize = 0;
            btnCatSalata.FlatStyle = FlatStyle.Flat;
            btnCatSalata.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCatSalata.ForeColor = Color.Black;
            btnCatSalata.Location = new Point(150, 100);
            btnCatSalata.Name = "btnCatSalata";
            btnCatSalata.Size = new Size(140, 90);
            btnCatSalata.TabIndex = 3;
            btnCatSalata.Tag = "SALATA";
            btnCatSalata.Text = "Salata";
            btnCatSalata.UseVisualStyleBackColor = false;
            btnCatSalata.Click += KategoriButon_Click;
            // 
            // btnCatFastfood
            // 
            btnCatFastfood.BackColor = Color.Olive;
            btnCatFastfood.FlatAppearance.BorderSize = 0;
            btnCatFastfood.FlatStyle = FlatStyle.Flat;
            btnCatFastfood.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCatFastfood.ForeColor = Color.Black;
            btnCatFastfood.Location = new Point(5, 195);
            btnCatFastfood.Name = "btnCatFastfood";
            btnCatFastfood.Size = new Size(140, 90);
            btnCatFastfood.TabIndex = 4;
            btnCatFastfood.Tag = "FASTFOOD";
            btnCatFastfood.Text = "Fast Food";
            btnCatFastfood.UseVisualStyleBackColor = false;
            btnCatFastfood.Click += KategoriButon_Click;
            // 
            // btnCatCorba
            // 
            btnCatCorba.BackColor = Color.SteelBlue;
            btnCatCorba.FlatAppearance.BorderSize = 0;
            btnCatCorba.FlatStyle = FlatStyle.Flat;
            btnCatCorba.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCatCorba.ForeColor = Color.Black;
            btnCatCorba.Location = new Point(150, 195);
            btnCatCorba.Name = "btnCatCorba";
            btnCatCorba.Size = new Size(140, 90);
            btnCatCorba.TabIndex = 5;
            btnCatCorba.Tag = "ÇORBA";
            btnCatCorba.Text = "Çorba";
            btnCatCorba.UseVisualStyleBackColor = false;
            btnCatCorba.Click += KategoriButon_Click;
            // 
            // btnCatMakarna
            // 
            btnCatMakarna.BackColor = Color.DarkSlateBlue;
            btnCatMakarna.FlatAppearance.BorderSize = 0;
            btnCatMakarna.FlatStyle = FlatStyle.Flat;
            btnCatMakarna.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCatMakarna.ForeColor = Color.Black;
            btnCatMakarna.Location = new Point(5, 290);
            btnCatMakarna.Name = "btnCatMakarna";
            btnCatMakarna.Size = new Size(140, 90);
            btnCatMakarna.TabIndex = 6;
            btnCatMakarna.Tag = "MAKARNA";
            btnCatMakarna.Text = "Makarna";
            btnCatMakarna.UseVisualStyleBackColor = false;
            btnCatMakarna.Click += KategoriButon_Click;
            // 
            // btnCatArasicak
            // 
            btnCatArasicak.BackColor = Color.FromArgb(128, 64, 64);
            btnCatArasicak.FlatAppearance.BorderSize = 0;
            btnCatArasicak.FlatStyle = FlatStyle.Flat;
            btnCatArasicak.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCatArasicak.ForeColor = Color.Black;
            btnCatArasicak.Location = new Point(150, 290);
            btnCatArasicak.Name = "btnCatArasicak";
            btnCatArasicak.Size = new Size(140, 90);
            btnCatArasicak.TabIndex = 7;
            btnCatArasicak.Tag = "ARASICAK";
            btnCatArasicak.Text = "Ara Sıcak";
            btnCatArasicak.UseVisualStyleBackColor = false;
            btnCatArasicak.Click += KategoriButon_Click;
            // 
            // btnCatTumUrunler
            // 
            btnCatTumUrunler.BackColor = Color.FromArgb(255, 255, 128);
            btnCatTumUrunler.FlatAppearance.BorderSize = 0;
            btnCatTumUrunler.FlatStyle = FlatStyle.Flat;
            btnCatTumUrunler.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCatTumUrunler.ForeColor = Color.Black;
            btnCatTumUrunler.Location = new Point(5, 385);
            btnCatTumUrunler.Name = "btnCatTumUrunler";
            btnCatTumUrunler.Size = new Size(285, 75);
            btnCatTumUrunler.TabIndex = 8;
            btnCatTumUrunler.Tag = "TÜM ÜRÜNLER";
            btnCatTumUrunler.Text = "Tüm Ürünler";
            btnCatTumUrunler.UseVisualStyleBackColor = false;
            btnCatTumUrunler.Click += KategoriButon_Click;
            // 
            // pnlGrafik
            // 
            pnlGrafik.BackColor = Color.FromArgb(255, 224, 192);
            pnlGrafik.BorderStyle = BorderStyle.FixedSingle;
            pnlGrafik.Location = new Point(324, 14);
            pnlGrafik.Name = "pnlGrafik";
            pnlGrafik.Size = new Size(810, 472);
            pnlGrafik.TabIndex = 1;
            // 
            // SatisRaporlariForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(1150, 500);
            Controls.Add(pnlGrafik);
            Controls.Add(pnlKategoriler);
            Controls.Add(dtpBaslangic);
            Controls.Add(dtpBitis);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SatisRaporlariForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış Raporları Grafiği";
            Load += SatisRaporlariForm_Load;
            pnlKategoriler.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
