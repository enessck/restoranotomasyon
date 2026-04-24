namespace RestaurantOtomasyon
{
    partial class frmRezervarsyon
    {
        private System.ComponentModel.IContainer components = null;

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
            lblTarih = new Label();
            lblMasaSec = new Label();
            lblKisiSayisi = new Label();
            lblAciklama = new Label();
            lblMusteri = new Label();
            lblTelefon = new Label();
            lblAdres = new Label();
            dtpTarih = new DateTimePicker();
            cmbMasaSec = new ComboBox();
            cmbKisiSayisi = new ComboBox();
            txtAciklama = new TextBox();
            txtMusteri = new TextBox();
            txtTelefon = new TextBox();
            txtAdres = new TextBox();
            dgvMusteriler = new DataGridView();
            colAd = new DataGridViewTextBoxColumn();
            colSoyad = new DataGridViewTextBoxColumn();
            colTelefon = new DataGridViewTextBoxColumn();
            colAdres = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            btnYeniMusteri = new Button();
            btnRezervasyonAc = new Button();
            btnRezervasyonlar = new Button();
            btnMusteriGuncelle = new Button();
            btnGeriDonBuyuk = new Button();
            btnGeriKucuk = new Button();
            btnCikisKucuk = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            SuspendLayout();
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Segoe UI", 12F);
            lblTarih.ForeColor = Color.Black;
            lblTarih.Location = new Point(41, 59);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(62, 28);
            lblTarih.TabIndex = 21;
            lblTarih.Text = "Tarih :";
            // 
            // lblMasaSec
            // 
            lblMasaSec.AutoSize = true;
            lblMasaSec.Font = new Font("Segoe UI", 12F);
            lblMasaSec.ForeColor = Color.Black;
            lblMasaSec.Location = new Point(12, 103);
            lblMasaSec.Name = "lblMasaSec";
            lblMasaSec.Size = new Size(102, 28);
            lblMasaSec.TabIndex = 19;
            lblMasaSec.Text = "Masa Seç :";
            // 
            // lblKisiSayisi
            // 
            lblKisiSayisi.AutoSize = true;
            lblKisiSayisi.Font = new Font("Segoe UI", 12F);
            lblKisiSayisi.ForeColor = Color.Black;
            lblKisiSayisi.Location = new Point(12, 161);
            lblKisiSayisi.Name = "lblKisiSayisi";
            lblKisiSayisi.Size = new Size(105, 28);
            lblKisiSayisi.TabIndex = 17;
            lblKisiSayisi.Text = "Kişi Sayısı :";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Font = new Font("Segoe UI", 12F);
            lblAciklama.ForeColor = Color.Black;
            lblAciklama.Location = new Point(15, 220);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(100, 28);
            lblAciklama.TabIndex = 15;
            lblAciklama.Text = "Açıklama :";
            // 
            // lblMusteri
            // 
            lblMusteri.AutoSize = true;
            lblMusteri.Font = new Font("Segoe UI", 14F);
            lblMusteri.ForeColor = Color.Black;
            lblMusteri.Location = new Point(400, 10);
            lblMusteri.Name = "lblMusteri";
            lblMusteri.Size = new Size(110, 32);
            lblMusteri.TabIndex = 13;
            lblMusteri.Text = "MÜŞTERİ";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 14F);
            lblTelefon.ForeColor = Color.Black;
            lblTelefon.Location = new Point(620, 10);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(110, 32);
            lblTelefon.TabIndex = 11;
            lblTelefon.Text = "TELEFON";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Font = new Font("Segoe UI", 14F);
            lblAdres.ForeColor = Color.Black;
            lblAdres.Location = new Point(840, 10);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(85, 32);
            lblAdres.TabIndex = 9;
            lblAdres.Text = "ADRES";
            // 
            // dtpTarih
            // 
            dtpTarih.Font = new Font("Segoe UI", 12F);
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(130, 53);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(221, 34);
            dtpTarih.TabIndex = 20;
            // 
            // cmbMasaSec
            // 
            cmbMasaSec.Font = new Font("Segoe UI", 12F);
            cmbMasaSec.FormattingEnabled = true;
            cmbMasaSec.Location = new Point(130, 100);
            cmbMasaSec.Name = "cmbMasaSec";
            cmbMasaSec.Size = new Size(221, 36);
            cmbMasaSec.TabIndex = 18;
            // 
            // cmbKisiSayisi
            // 
            cmbKisiSayisi.Font = new Font("Segoe UI", 12F);
            cmbKisiSayisi.FormattingEnabled = true;
            cmbKisiSayisi.Location = new Point(130, 158);
            cmbKisiSayisi.Name = "cmbKisiSayisi";
            cmbKisiSayisi.Size = new Size(221, 36);
            cmbKisiSayisi.TabIndex = 16;
            // 
            // txtAciklama
            // 
            txtAciklama.Font = new Font("Segoe UI", 12F);
            txtAciklama.Location = new Point(130, 220);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(228, 200);
            txtAciklama.TabIndex = 14;
            // 
            // txtMusteri
            // 
            txtMusteri.Font = new Font("Segoe UI", 14F);
            txtMusteri.Location = new Point(400, 48);
            txtMusteri.Name = "txtMusteri";
            txtMusteri.Size = new Size(200, 39);
            txtMusteri.TabIndex = 12;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Segoe UI", 14F);
            txtTelefon.Location = new Point(620, 48);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(200, 39);
            txtTelefon.TabIndex = 10;
            // 
            // txtAdres
            // 
            txtAdres.Font = new Font("Segoe UI", 14F);
            txtAdres.Location = new Point(840, 48);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(260, 39);
            txtAdres.TabIndex = 8;
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.AllowUserToAddRows = false;
            dgvMusteriler.AllowUserToDeleteRows = false;
            dgvMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMusteriler.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMusteriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMusteriler.ColumnHeadersHeight = 40;
            dgvMusteriler.Columns.AddRange(new DataGridViewColumn[] { colAd, colSoyad, colTelefon, colAdres, colEmail });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMusteriler.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMusteriler.Location = new Point(400, 100);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.ReadOnly = true;
            dgvMusteriler.RowHeadersVisible = false;
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.RowTemplate.Height = 35;
            dgvMusteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMusteriler.Size = new Size(768, 411);
            dgvMusteriler.TabIndex = 7;
            dgvMusteriler.CellContentClick += dgvMusteriler_CellContentClick;
            dgvMusteriler.SelectionChanged += dgvMusteriler_SelectionChanged;
            // 
            // colAd
            // 
            colAd.HeaderText = "Ad";
            colAd.MinimumWidth = 6;
            colAd.Name = "colAd";
            colAd.ReadOnly = true;
            // 
            // colSoyad
            // 
            colSoyad.HeaderText = "Soyad";
            colSoyad.MinimumWidth = 6;
            colSoyad.Name = "colSoyad";
            colSoyad.ReadOnly = true;
            // 
            // colTelefon
            // 
            colTelefon.HeaderText = "Telefon";
            colTelefon.MinimumWidth = 6;
            colTelefon.Name = "colTelefon";
            colTelefon.ReadOnly = true;
            // 
            // colAdres
            // 
            colAdres.HeaderText = "Adres";
            colAdres.MinimumWidth = 6;
            colAdres.Name = "colAdres";
            colAdres.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // btnYeniMusteri
            // 
            btnYeniMusteri.BackColor = Color.FromArgb(255, 128, 128);
            btnYeniMusteri.FlatAppearance.BorderSize = 0;
            btnYeniMusteri.FlatStyle = FlatStyle.Flat;
            btnYeniMusteri.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnYeniMusteri.ForeColor = Color.White;
            btnYeniMusteri.Location = new Point(-1, 517);
            btnYeniMusteri.Name = "btnYeniMusteri";
            btnYeniMusteri.Size = new Size(260, 110);
            btnYeniMusteri.TabIndex = 6;
            btnYeniMusteri.Text = "  Yeni Müşteri";
            btnYeniMusteri.UseVisualStyleBackColor = false;
            btnYeniMusteri.Click += btnYeniMusteri_Click;
            // 
            // btnRezervasyonAc
            // 
            btnRezervasyonAc.BackColor = Color.DarkOliveGreen;
            btnRezervasyonAc.FlatAppearance.BorderSize = 0;
            btnRezervasyonAc.FlatStyle = FlatStyle.Flat;
            btnRezervasyonAc.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRezervasyonAc.ForeColor = Color.White;
            btnRezervasyonAc.Location = new Point(265, 517);
            btnRezervasyonAc.Name = "btnRezervasyonAc";
            btnRezervasyonAc.Size = new Size(260, 110);
            btnRezervasyonAc.TabIndex = 5;
            btnRezervasyonAc.Text = "Rezervasyon Aç";
            btnRezervasyonAc.UseVisualStyleBackColor = false;
            btnRezervasyonAc.Click += btnRezervasyonAc_Click;
            // 
            // btnRezervasyonlar
            // 
            btnRezervasyonlar.BackColor = Color.Teal;
            btnRezervasyonlar.FlatAppearance.BorderSize = 0;
            btnRezervasyonlar.FlatStyle = FlatStyle.Flat;
            btnRezervasyonlar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRezervasyonlar.ForeColor = Color.White;
            btnRezervasyonlar.Location = new Point(531, 517);
            btnRezervasyonlar.Name = "btnRezervasyonlar";
            btnRezervasyonlar.Size = new Size(260, 110);
            btnRezervasyonlar.TabIndex = 4;
            btnRezervasyonlar.Text = "Rezervasyonlar";
            btnRezervasyonlar.UseVisualStyleBackColor = false;
            // 
            // btnMusteriGuncelle
            // 
            btnMusteriGuncelle.BackColor = Color.FromArgb(128, 64, 64);
            btnMusteriGuncelle.FlatAppearance.BorderSize = 0;
            btnMusteriGuncelle.FlatStyle = FlatStyle.Flat;
            btnMusteriGuncelle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMusteriGuncelle.ForeColor = Color.White;
            btnMusteriGuncelle.Location = new Point(797, 517);
            btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            btnMusteriGuncelle.Size = new Size(260, 110);
            btnMusteriGuncelle.TabIndex = 3;
            btnMusteriGuncelle.Text = "Müşteri Güncelle";
            btnMusteriGuncelle.UseVisualStyleBackColor = false;
            btnMusteriGuncelle.Click += btnMusteriGuncelle_Click;
            // 
            // btnGeriDonBuyuk
            // 
            btnGeriDonBuyuk.BackColor = Color.FromArgb(128, 128, 255);
            btnGeriDonBuyuk.FlatAppearance.BorderSize = 0;
            btnGeriDonBuyuk.FlatStyle = FlatStyle.Flat;
            btnGeriDonBuyuk.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGeriDonBuyuk.ForeColor = Color.White;
            btnGeriDonBuyuk.Location = new Point(1063, 517);
            btnGeriDonBuyuk.Name = "btnGeriDonBuyuk";
            btnGeriDonBuyuk.Size = new Size(177, 110);
            btnGeriDonBuyuk.TabIndex = 2;
            btnGeriDonBuyuk.Text = "Geri Dön";
            btnGeriDonBuyuk.UseVisualStyleBackColor = false;
            btnGeriDonBuyuk.Click += btnGeriDon_Click;
            // 
            // btnGeriKucuk
            // 
            btnGeriKucuk.BackColor = Color.FromArgb(192, 64, 0);
            btnGeriKucuk.FlatAppearance.BorderSize = 0;
            btnGeriKucuk.FlatStyle = FlatStyle.Flat;
            btnGeriKucuk.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnGeriKucuk.ForeColor = Color.White;
            btnGeriKucuk.Location = new Point(1190, 10);
            btnGeriKucuk.Name = "btnGeriKucuk";
            btnGeriKucuk.Size = new Size(50, 50);
            btnGeriKucuk.TabIndex = 1;
            btnGeriKucuk.Text = "↺";
            btnGeriKucuk.UseVisualStyleBackColor = false;
            btnGeriKucuk.Click += btnGeriDon_Click;
            // 
            // btnCikisKucuk
            // 
            btnCikisKucuk.BackColor = Color.Green;
            btnCikisKucuk.FlatAppearance.BorderSize = 0;
            btnCikisKucuk.FlatStyle = FlatStyle.Flat;
            btnCikisKucuk.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCikisKucuk.ForeColor = Color.White;
            btnCikisKucuk.Location = new Point(1134, 10);
            btnCikisKucuk.Name = "btnCikisKucuk";
            btnCikisKucuk.Size = new Size(50, 50);
            btnCikisKucuk.TabIndex = 0;
            btnCikisKucuk.Text = "⏸";
            btnCikisKucuk.UseVisualStyleBackColor = false;
            btnCikisKucuk.Click += btnCikis_Click;
            // 
            // frmRezervarsyon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1250, 650);
            Controls.Add(btnCikisKucuk);
            Controls.Add(btnGeriKucuk);
            Controls.Add(btnGeriDonBuyuk);
            Controls.Add(btnMusteriGuncelle);
            Controls.Add(btnRezervasyonlar);
            Controls.Add(btnRezervasyonAc);
            Controls.Add(btnYeniMusteri);
            Controls.Add(dgvMusteriler);
            Controls.Add(txtAdres);
            Controls.Add(lblAdres);
            Controls.Add(txtTelefon);
            Controls.Add(lblTelefon);
            Controls.Add(txtMusteri);
            Controls.Add(lblMusteri);
            Controls.Add(txtAciklama);
            Controls.Add(lblAciklama);
            Controls.Add(cmbKisiSayisi);
            Controls.Add(lblKisiSayisi);
            Controls.Add(cmbMasaSec);
            Controls.Add(lblMasaSec);
            Controls.Add(dtpTarih);
            Controls.Add(lblTarih);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRezervarsyon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rezervasyon Yönetimi";
            Load += RezervasyonlarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblMasaSec;
        private System.Windows.Forms.ComboBox cmbMasaSec;
        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.ComboBox cmbKisiSayisi;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;
        
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnRezervasyonAc;
        private System.Windows.Forms.Button btnRezervasyonlar;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnGeriDonBuyuk;
        private System.Windows.Forms.Button btnGeriKucuk;
        private System.Windows.Forms.Button btnCikisKucuk;
    }
}
