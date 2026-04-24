namespace RestaurantOtomasyon
{
    partial class frmMusteriGuncelle
    {
        private System.ComponentModel.IContainer components = null;

        // Top search fields (visual match with CustomersForm)
        private System.Windows.Forms.Label lblTopAdi;
        private System.Windows.Forms.Label lblTopSoyadi;
        private System.Windows.Forms.Label lblTopTelefon;
        private System.Windows.Forms.Label lblTopAdres;
        private System.Windows.Forms.Label lblTopEMail;
        private System.Windows.Forms.Label lblTopAdisyonId;
        private System.Windows.Forms.TextBox txtTopAdi;
        private System.Windows.Forms.TextBox txtTopSoyadi;
        private System.Windows.Forms.TextBox txtTopTelefon;
        private System.Windows.Forms.TextBox txtTopAdres;
        private System.Windows.Forms.TextBox txtTopEMail;
        private System.Windows.Forms.TextBox txtTopAdisyonId;

        // Center edit fields
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;

        // Bottom buttons
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnGeri;

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
            lblTopAdi = new Label();
            lblTopSoyadi = new Label();
            lblTopTelefon = new Label();
            lblTopAdres = new Label();
            lblTopEMail = new Label();
            lblTopAdisyonId = new Label();
            txtTopAdi = new TextBox();
            txtTopSoyadi = new TextBox();
            txtTopTelefon = new TextBox();
            txtTopAdres = new TextBox();
            txtTopEMail = new TextBox();
            txtTopAdisyonId = new TextBox();
            lblName = new Label();
            lblSurname = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblEmail = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnKapat = new Button();
            btnGeri = new Button();
            SuspendLayout();
            // 
            // lblTopAdi
            // 
            lblTopAdi.AutoSize = true;
            lblTopAdi.BackColor = Color.Black;
            lblTopAdi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTopAdi.ForeColor = Color.White;
            lblTopAdi.Location = new Point(39, 13);
            lblTopAdi.Name = "lblTopAdi";
            lblTopAdi.Size = new Size(37, 25);
            lblTopAdi.TabIndex = 0;
            lblTopAdi.Text = "Ad";
            // 
            // lblTopSoyadi
            // 
            lblTopSoyadi.AutoSize = true;
            lblTopSoyadi.BackColor = Color.Black;
            lblTopSoyadi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTopSoyadi.ForeColor = Color.White;
            lblTopSoyadi.Location = new Point(178, 13);
            lblTopSoyadi.Name = "lblTopSoyadi";
            lblTopSoyadi.Size = new Size(67, 25);
            lblTopSoyadi.TabIndex = 1;
            lblTopSoyadi.Text = "Soyad";
            // 
            // lblTopTelefon
            // 
            lblTopTelefon.AutoSize = true;
            lblTopTelefon.BackColor = Color.Black;
            lblTopTelefon.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTopTelefon.ForeColor = Color.White;
            lblTopTelefon.Location = new Point(290, 13);
            lblTopTelefon.Name = "lblTopTelefon";
            lblTopTelefon.Size = new Size(167, 25);
            lblTopTelefon.TabIndex = 2;
            lblTopTelefon.Text = "Telefon Numarası";
            // 
            // lblTopAdres
            // 
            lblTopAdres.AutoSize = true;
            lblTopAdres.BackColor = Color.Black;
            lblTopAdres.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTopAdres.ForeColor = Color.White;
            lblTopAdres.Location = new Point(808, 13);
            lblTopAdres.Name = "lblTopAdres";
            lblTopAdres.Size = new Size(63, 25);
            lblTopAdres.TabIndex = 5;
            lblTopAdres.Text = "Adres";
            // 
            // lblTopEMail
            // 
            lblTopEMail.AutoSize = true;
            lblTopEMail.BackColor = Color.Black;
            lblTopEMail.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTopEMail.ForeColor = Color.White;
            lblTopEMail.Location = new Point(503, 13);
            lblTopEMail.Name = "lblTopEMail";
            lblTopEMail.Size = new Size(77, 25);
            lblTopEMail.TabIndex = 3;
            lblTopEMail.Text = "E-MAIL";
            // 
            // lblTopAdisyonId
            // 
            lblTopAdisyonId.AutoSize = true;
            lblTopAdisyonId.BackColor = Color.Black;
            lblTopAdisyonId.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTopAdisyonId.ForeColor = Color.White;
            lblTopAdisyonId.Location = new Point(626, 13);
            lblTopAdisyonId.Name = "lblTopAdisyonId";
            lblTopAdisyonId.Size = new Size(84, 25);
            lblTopAdisyonId.TabIndex = 4;
            lblTopAdisyonId.Text = "Adisyon";
            // 
            // txtTopAdi
            // 
            txtTopAdi.Font = new Font("Segoe UI", 10F);
            txtTopAdi.Location = new Point(1, 47);
            txtTopAdi.Name = "txtTopAdi";
            txtTopAdi.ReadOnly = true;
            txtTopAdi.Size = new Size(137, 30);
            txtTopAdi.TabIndex = 6;
            // 
            // txtTopSoyadi
            // 
            txtTopSoyadi.Font = new Font("Segoe UI", 10F);
            txtTopSoyadi.Location = new Point(144, 47);
            txtTopSoyadi.Name = "txtTopSoyadi";
            txtTopSoyadi.ReadOnly = true;
            txtTopSoyadi.Size = new Size(137, 30);
            txtTopSoyadi.TabIndex = 7;
            // 
            // txtTopTelefon
            // 
            txtTopTelefon.Font = new Font("Segoe UI", 10F);
            txtTopTelefon.Location = new Point(287, 47);
            txtTopTelefon.Name = "txtTopTelefon";
            txtTopTelefon.ReadOnly = true;
            txtTopTelefon.Size = new Size(170, 30);
            txtTopTelefon.TabIndex = 8;
            // 
            // txtTopAdres
            // 
            txtTopAdres.Font = new Font("Segoe UI", 10F);
            txtTopAdres.Location = new Point(773, 47);
            txtTopAdres.Name = "txtTopAdres";
            txtTopAdres.ReadOnly = true;
            txtTopAdres.Size = new Size(158, 30);
            txtTopAdres.TabIndex = 11;
            // 
            // txtTopEMail
            // 
            txtTopEMail.Font = new Font("Segoe UI", 10F);
            txtTopEMail.Location = new Point(473, 47);
            txtTopEMail.Name = "txtTopEMail";
            txtTopEMail.ReadOnly = true;
            txtTopEMail.Size = new Size(137, 30);
            txtTopEMail.TabIndex = 9;
            // 
            // txtTopAdisyonId
            // 
            txtTopAdisyonId.Font = new Font("Segoe UI", 10F);
            txtTopAdisyonId.Location = new Point(626, 47);
            txtTopAdisyonId.Name = "txtTopAdisyonId";
            txtTopAdisyonId.ReadOnly = true;
            txtTopAdisyonId.Size = new Size(122, 30);
            txtTopAdisyonId.TabIndex = 10;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(100, 105);
            lblName.Name = "lblName";
            lblName.Size = new Size(250, 32);
            lblName.TabIndex = 12;
            lblName.Text = "Müşteri Adı =";
            lblName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSurname
            // 
            lblSurname.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblSurname.ForeColor = Color.Black;
            lblSurname.Location = new Point(100, 152);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(250, 32);
            lblSurname.TabIndex = 14;
            lblSurname.Text = "Müşteri Soyadı =";
            lblSurname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            lblPhone.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPhone.ForeColor = Color.Black;
            lblPhone.Location = new Point(100, 199);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(250, 32);
            lblPhone.TabIndex = 16;
            lblPhone.Text = "Telefon Numarası =";
            lblPhone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblAddress.ForeColor = Color.Black;
            lblAddress.Location = new Point(100, 248);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(250, 32);
            lblAddress.TabIndex = 18;
            lblAddress.Text = "Adres =";
            lblAddress.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(100, 355);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(250, 32);
            lblEmail.TabIndex = 20;
            lblEmail.Text = "E-Mail =";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13F);
            txtName.Location = new Point(360, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(365, 36);
            txtName.TabIndex = 13;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 13F);
            txtSurname.Location = new Point(360, 150);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(365, 36);
            txtSurname.TabIndex = 15;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 13F);
            txtPhone.Location = new Point(360, 197);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(365, 36);
            txtPhone.TabIndex = 17;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(360, 246);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(365, 90);
            txtAddress.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13F);
            txtEmail.Location = new Point(360, 353);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(365, 36);
            txtEmail.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 128, 128);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1, 453);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(183, 73);
            btnSave.TabIndex = 22;
            btnSave.Text = "👤+ YENİ\n     MÜŞTERİ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.FromArgb(255, 192, 128);
            btnKapat.FlatAppearance.BorderSize = 0;
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnKapat.ForeColor = Color.White;
            btnKapat.Location = new Point(760, 453);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(183, 73);
            btnKapat.TabIndex = 23;
            btnKapat.Text = "☑ MÜŞTERİ\n      SEÇ";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.FromArgb(128, 64, 0);
            btnGeri.FlatAppearance.BorderSize = 0;
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btnGeri.ForeColor = Color.White;
            btnGeri.Location = new Point(450, 453);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(115, 73);
            btnGeri.TabIndex = 24;
            btnGeri.Text = "↻";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // frmMusteriGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(943, 527);
            Controls.Add(lblTopAdi);
            Controls.Add(lblTopSoyadi);
            Controls.Add(lblTopTelefon);
            Controls.Add(lblTopEMail);
            Controls.Add(lblTopAdisyonId);
            Controls.Add(lblTopAdres);
            Controls.Add(txtTopAdi);
            Controls.Add(txtTopSoyadi);
            Controls.Add(txtTopTelefon);
            Controls.Add(txtTopEMail);
            Controls.Add(txtTopAdisyonId);
            Controls.Add(txtTopAdres);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblSurname);
            Controls.Add(txtSurname);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnSave);
            Controls.Add(btnKapat);
            Controls.Add(btnGeri);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMusteriGuncelle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Düzenle";
            Load += CustomerEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
