namespace RestaurantOtomasyon
{
    partial class frmMutfak
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblGidaKategorisi;
        private System.Windows.Forms.ComboBox cmbGidaKategorisi;
        private System.Windows.Forms.Label lblGidaAdi;
        private System.Windows.Forms.TextBox txtGidaAdi;
        private System.Windows.Forms.Label lblGidaFiyati;
        private System.Windows.Forms.TextBox txtGidaFiyati;
        private System.Windows.Forms.Button btnUrunKategoriEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnKapat;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblGidaKategorisi = new Label();
            cmbGidaKategorisi = new ComboBox();
            lblGidaAdi = new Label();
            txtGidaAdi = new TextBox();
            lblGidaFiyati = new Label();
            txtGidaFiyati = new TextBox();
            btnUrunKategoriEkle = new Button();
            btnEkle = new Button();
            btnDegistir = new Button();
            btnBul = new Button();
            btnSil = new Button();
            dgvUrunler = new DataGridView();
            btnYenile = new Button();
            btnKapat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // lblGidaKategorisi
            // 
            lblGidaKategorisi.AutoSize = true;
            lblGidaKategorisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGidaKategorisi.ForeColor = Color.Black;
            lblGidaKategorisi.Location = new Point(119, 29);
            lblGidaKategorisi.Name = "lblGidaKategorisi";
            lblGidaKategorisi.Size = new Size(177, 28);
            lblGidaKategorisi.TabIndex = 0;
            lblGidaKategorisi.Text = "Gıda Kategorisi =";
            // 
            // cmbGidaKategorisi
            // 
            cmbGidaKategorisi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGidaKategorisi.Font = new Font("Segoe UI", 12F);
            cmbGidaKategorisi.Location = new Point(302, 21);
            cmbGidaKategorisi.Name = "cmbGidaKategorisi";
            cmbGidaKategorisi.Size = new Size(280, 36);
            cmbGidaKategorisi.TabIndex = 1;
            // 
            // lblGidaAdi
            // 
            lblGidaAdi.AutoSize = true;
            lblGidaAdi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGidaAdi.ForeColor = Color.Black;
            lblGidaAdi.Location = new Point(183, 80);
            lblGidaAdi.Name = "lblGidaAdi";
            lblGidaAdi.Size = new Size(113, 28);
            lblGidaAdi.TabIndex = 2;
            lblGidaAdi.Text = "Gıda Adı =";
            lblGidaAdi.Click += lblGidaAdi_Click;
            // 
            // txtGidaAdi
            // 
            txtGidaAdi.Font = new Font("Segoe UI", 12F);
            txtGidaAdi.Location = new Point(302, 74);
            txtGidaAdi.Name = "txtGidaAdi";
            txtGidaAdi.Size = new Size(280, 34);
            txtGidaAdi.TabIndex = 3;
            // 
            // lblGidaFiyati
            // 
            lblGidaFiyati.AutoSize = true;
            lblGidaFiyati.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGidaFiyati.ForeColor = Color.Black;
            lblGidaFiyati.Location = new Point(163, 130);
            lblGidaFiyati.Name = "lblGidaFiyati";
            lblGidaFiyati.Size = new Size(133, 28);
            lblGidaFiyati.TabIndex = 4;
            lblGidaFiyati.Text = "Gıda Fiyatı =";
            // 
            // txtGidaFiyati
            // 
            txtGidaFiyati.Font = new Font("Segoe UI", 12F);
            txtGidaFiyati.Location = new Point(302, 124);
            txtGidaFiyati.Name = "txtGidaFiyati";
            txtGidaFiyati.Size = new Size(280, 34);
            txtGidaFiyati.TabIndex = 5;
            // 
            // btnUrunKategoriEkle
            // 
            btnUrunKategoriEkle.BackColor = Color.FromArgb(128, 64, 0);
            btnUrunKategoriEkle.FlatAppearance.BorderColor = Color.Gray;
            btnUrunKategoriEkle.FlatStyle = FlatStyle.Flat;
            btnUrunKategoriEkle.Font = new Font("Segoe UI", 9F);
            btnUrunKategoriEkle.ForeColor = Color.White;
            btnUrunKategoriEkle.Location = new Point(611, 15);
            btnUrunKategoriEkle.Name = "btnUrunKategoriEkle";
            btnUrunKategoriEkle.Size = new Size(140, 42);
            btnUrunKategoriEkle.TabIndex = 6;
            btnUrunKategoriEkle.Text = "Ürün Kategori Ekle";
            btnUrunKategoriEkle.UseVisualStyleBackColor = false;
            btnUrunKategoriEkle.Click += btnUrunKategoriEkle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(255, 128, 128);
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(16, 211);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(197, 70);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.BackColor = Color.FromArgb(192, 255, 192);
            btnDegistir.FlatAppearance.BorderSize = 0;
            btnDegistir.FlatStyle = FlatStyle.Flat;
            btnDegistir.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDegistir.ForeColor = Color.White;
            btnDegistir.Location = new Point(237, 211);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(195, 70);
            btnDegistir.TabIndex = 8;
            btnDegistir.Text = "DEĞİŞTİR";
            btnDegistir.UseVisualStyleBackColor = false;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnBul
            // 
            btnBul.BackColor = Color.FromArgb(128, 128, 255);
            btnBul.FlatAppearance.BorderSize = 0;
            btnBul.FlatStyle = FlatStyle.Flat;
            btnBul.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnBul.ForeColor = Color.White;
            btnBul.Location = new Point(461, 211);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(189, 70);
            btnBul.TabIndex = 9;
            btnBul.Text = "BUL";
            btnBul.UseVisualStyleBackColor = false;
            btnBul.Click += btnBul_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Teal;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(680, 211);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(188, 70);
            btnSil.TabIndex = 10;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // dgvUrunler
            // 
            dgvUrunler.AllowUserToAddRows = false;
            dgvUrunler.AllowUserToDeleteRows = false;
            dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUrunler.BackgroundColor = Color.White;
            dgvUrunler.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUrunler.ColumnHeadersHeight = 40;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(70, 100, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUrunler.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUrunler.EnableHeadersVisualStyles = false;
            dgvUrunler.Location = new Point(12, 287);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.ReadOnly = true;
            dgvUrunler.RowHeadersVisible = false;
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.RowTemplate.Height = 35;
            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.Size = new Size(876, 329);
            dgvUrunler.TabIndex = 11;
            dgvUrunler.CellClick += dgvUrunler_CellClick;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = Color.FromArgb(64, 64, 64);
            btnYenile.FlatAppearance.BorderSize = 0;
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnYenile.ForeColor = Color.White;
            btnYenile.Location = new Point(767, 10);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(53, 52);
            btnYenile.TabIndex = 12;
            btnYenile.Text = "↻";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.FromArgb(180, 80, 0);
            btnKapat.FlatAppearance.BorderSize = 0;
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnKapat.ForeColor = Color.White;
            btnKapat.Location = new Point(835, 10);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(53, 52);
            btnKapat.TabIndex = 13;
            btnKapat.Text = "\u23fb";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // frmMutfak
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(900, 620);
            Controls.Add(btnKapat);
            Controls.Add(btnYenile);
            Controls.Add(dgvUrunler);
            Controls.Add(btnSil);
            Controls.Add(btnBul);
            Controls.Add(btnDegistir);
            Controls.Add(btnEkle);
            Controls.Add(btnUrunKategoriEkle);
            Controls.Add(txtGidaFiyati);
            Controls.Add(lblGidaFiyati);
            Controls.Add(txtGidaAdi);
            Controls.Add(lblGidaAdi);
            Controls.Add(cmbGidaKategorisi);
            Controls.Add(lblGidaKategorisi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMutfak";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menü Yönetimi - Ürünler";
            Load += MutfakForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
