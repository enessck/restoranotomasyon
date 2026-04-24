using System.Drawing;
using System.Windows.Forms;

namespace RestaurantOtomasyon
{
    partial class frmSettings
    {
        private System.ComponentModel.IContainer components = null;

        // Top bar
        private System.Windows.Forms.Label lblMevki;

        // Left panel – password change
        private System.Windows.Forms.Panel pnlPasswordChange;
        private System.Windows.Forms.ComboBox cmbUserSelect;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label lblTYeniSifre;
        private System.Windows.Forms.TextBox txtTYeniSifre;
        private System.Windows.Forms.Button btnSifreDegistir;

        // Right panel – user management
        private System.Windows.Forms.Panel pnlUserManagement;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifreTekrar;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Label lblGorevi;
        private System.Windows.Forms.ComboBox cmbGorevi;

        // Action buttons
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;

        // DataGridView
        private System.Windows.Forms.DataGridView dgvUsers;

        // Bottom buttons
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
            lblMevki = new Label();
            pnlPasswordChange = new Panel();
            cmbUserSelect = new ComboBox();
            lblYeniSifre = new Label();
            txtYeniSifre = new TextBox();
            lblTYeniSifre = new Label();
            txtTYeniSifre = new TextBox();
            btnSifreDegistir = new Button();
            pnlUserManagement = new Panel();
            lblAdi = new Label();
            txtAdi = new TextBox();
            lblSoyad = new Label();
            txtSoyad = new TextBox();
            lblSifre = new Label();
            txtSifre = new TextBox();
            lblSifreTekrar = new Label();
            txtSifreTekrar = new TextBox();
            lblGorevi = new Label();
            cmbGorevi = new ComboBox();
            btnYeni = new Button();
            btnKaydet = new Button();
            btnSil = new Button();
            btnDegistir = new Button();
            dgvUsers = new DataGridView();
            btnYenile = new Button();
            btnKapat = new Button();
            pnlPasswordChange.SuspendLayout();
            pnlUserManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // lblMevki
            // 
            lblMevki.AutoSize = true;
            lblMevki.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblMevki.ForeColor = Color.Black;
            lblMevki.Location = new Point(179, 45);
            lblMevki.Name = "lblMevki";
            lblMevki.Size = new Size(496, 25);
            lblMevki.TabIndex = 5;
            lblMevki.Text = "Mevki : Müdür / Yetki Sınırsız / Kullanıcı : Enes Çakmak";
            // 
            // pnlPasswordChange
            // 
            pnlPasswordChange.BorderStyle = BorderStyle.FixedSingle;
            pnlPasswordChange.Controls.Add(cmbUserSelect);
            pnlPasswordChange.Controls.Add(lblYeniSifre);
            pnlPasswordChange.Controls.Add(txtYeniSifre);
            pnlPasswordChange.Controls.Add(lblTYeniSifre);
            pnlPasswordChange.Controls.Add(txtTYeniSifre);
            pnlPasswordChange.Controls.Add(btnSifreDegistir);
            pnlPasswordChange.Location = new Point(14, 89);
            pnlPasswordChange.Margin = new Padding(3, 4, 3, 4);
            pnlPasswordChange.Name = "pnlPasswordChange";
            pnlPasswordChange.Size = new Size(338, 403);
            pnlPasswordChange.TabIndex = 4;
            // 
            // cmbUserSelect
            // 
            cmbUserSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserSelect.Font = new Font("Segoe UI", 11F);
            cmbUserSelect.Location = new Point(177, 24);
            cmbUserSelect.Margin = new Padding(3, 4, 3, 4);
            cmbUserSelect.Name = "cmbUserSelect";
            cmbUserSelect.Size = new Size(138, 33);
            cmbUserSelect.TabIndex = 0;
            // 
            // lblYeniSifre
            // 
            lblYeniSifre.AutoSize = true;
            lblYeniSifre.Font = new Font("Segoe UI", 11.25F);
            lblYeniSifre.ForeColor = Color.Black;
            lblYeniSifre.Location = new Point(64, 80);
            lblYeniSifre.Name = "lblYeniSifre";
            lblYeniSifre.Size = new Size(90, 25);
            lblYeniSifre.TabIndex = 1;
            lblYeniSifre.Text = "Yeni Şifre";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Font = new Font("Segoe UI", 11F);
            txtYeniSifre.Location = new Point(177, 73);
            txtYeniSifre.Margin = new Padding(3, 4, 3, 4);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(138, 32);
            txtYeniSifre.TabIndex = 2;
            txtYeniSifre.UseSystemPasswordChar = true;
            // 
            // lblTYeniSifre
            // 
            lblTYeniSifre.AutoSize = true;
            lblTYeniSifre.Font = new Font("Segoe UI", 11.25F);
            lblTYeniSifre.ForeColor = Color.Black;
            lblTYeniSifre.Location = new Point(25, 127);
            lblTYeniSifre.Name = "lblTYeniSifre";
            lblTYeniSifre.Size = new Size(146, 25);
            lblTYeniSifre.TabIndex = 3;
            lblTYeniSifre.Text = "Tekrar Yeni Şifre";
            // 
            // txtTYeniSifre
            // 
            txtTYeniSifre.Font = new Font("Segoe UI", 11F);
            txtTYeniSifre.Location = new Point(177, 120);
            txtTYeniSifre.Margin = new Padding(3, 4, 3, 4);
            txtTYeniSifre.Name = "txtTYeniSifre";
            txtTYeniSifre.Size = new Size(138, 32);
            txtTYeniSifre.TabIndex = 4;
            txtTYeniSifre.UseSystemPasswordChar = true;
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.BackColor = Color.FromArgb(128, 64, 0);
            btnSifreDegistir.FlatAppearance.BorderSize = 0;
            btnSifreDegistir.FlatStyle = FlatStyle.Flat;
            btnSifreDegistir.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnSifreDegistir.ForeColor = Color.White;
            btnSifreDegistir.Location = new Point(105, 197);
            btnSifreDegistir.Margin = new Padding(3, 4, 3, 4);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(210, 121);
            btnSifreDegistir.TabIndex = 5;
            btnSifreDegistir.Text = "↻ DEĞİŞTİR";
            btnSifreDegistir.UseVisualStyleBackColor = false;
            btnSifreDegistir.Click += btnSifreDegistir_Click;
            // 
            // pnlUserManagement
            // 
            pnlUserManagement.BorderStyle = BorderStyle.FixedSingle;
            pnlUserManagement.Controls.Add(lblAdi);
            pnlUserManagement.Controls.Add(txtAdi);
            pnlUserManagement.Controls.Add(lblSoyad);
            pnlUserManagement.Controls.Add(txtSoyad);
            pnlUserManagement.Controls.Add(lblSifre);
            pnlUserManagement.Controls.Add(txtSifre);
            pnlUserManagement.Controls.Add(lblSifreTekrar);
            pnlUserManagement.Controls.Add(txtSifreTekrar);
            pnlUserManagement.Controls.Add(lblGorevi);
            pnlUserManagement.Controls.Add(cmbGorevi);
            pnlUserManagement.Controls.Add(btnYeni);
            pnlUserManagement.Controls.Add(btnKaydet);
            pnlUserManagement.Controls.Add(btnSil);
            pnlUserManagement.Controls.Add(btnDegistir);
            pnlUserManagement.Location = new Point(358, 89);
            pnlUserManagement.Margin = new Padding(3, 4, 3, 4);
            pnlUserManagement.Name = "pnlUserManagement";
            pnlUserManagement.Size = new Size(530, 403);
            pnlUserManagement.TabIndex = 3;
            // 
            // lblAdi
            // 
            lblAdi.AutoSize = true;
            lblAdi.Font = new Font("Segoe UI", 11.25F);
            lblAdi.ForeColor = Color.Black;
            lblAdi.Location = new Point(178, 31);
            lblAdi.Name = "lblAdi";
            lblAdi.Size = new Size(35, 25);
            lblAdi.TabIndex = 0;
            lblAdi.Text = "Ad";
            // 
            // txtAdi
            // 
            txtAdi.Font = new Font("Segoe UI", 11F);
            txtAdi.Location = new Point(219, 28);
            txtAdi.Margin = new Padding(3, 4, 3, 4);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(278, 32);
            txtAdi.TabIndex = 1;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 11.25F);
            lblSoyad.ForeColor = Color.Black;
            lblSoyad.Location = new Point(150, 80);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(63, 25);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 11F);
            txtSoyad.Location = new Point(219, 77);
            txtSoyad.Margin = new Padding(3, 4, 3, 4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(278, 32);
            txtSoyad.TabIndex = 3;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI", 11.25F);
            lblSifre.ForeColor = Color.Black;
            lblSifre.Location = new Point(163, 127);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(50, 25);
            lblSifre.TabIndex = 4;
            lblSifre.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 11F);
            txtSifre.Location = new Point(219, 120);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(278, 32);
            txtSifre.TabIndex = 5;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // lblSifreTekrar
            // 
            lblSifreTekrar.AutoSize = true;
            lblSifreTekrar.Font = new Font("Segoe UI", 11.25F);
            lblSifreTekrar.ForeColor = Color.Black;
            lblSifreTekrar.Location = new Point(107, 170);
            lblSifreTekrar.Name = "lblSifreTekrar";
            lblSifreTekrar.Size = new Size(106, 25);
            lblSifreTekrar.TabIndex = 6;
            lblSifreTekrar.Text = "Şifre Tekrar";
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Font = new Font("Segoe UI", 11F);
            txtSifreTekrar.Location = new Point(219, 167);
            txtSifreTekrar.Margin = new Padding(3, 4, 3, 4);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(278, 32);
            txtSifreTekrar.TabIndex = 7;
            txtSifreTekrar.UseSystemPasswordChar = true;
            // 
            // lblGorevi
            // 
            lblGorevi.AutoSize = true;
            lblGorevi.Font = new Font("Segoe UI", 11.25F);
            lblGorevi.ForeColor = Color.Black;
            lblGorevi.Location = new Point(146, 216);
            lblGorevi.Name = "lblGorevi";
            lblGorevi.Size = new Size(67, 25);
            lblGorevi.TabIndex = 8;
            lblGorevi.Text = "Görevi";
            lblGorevi.Click += lblGorevi_Click;
            // 
            // cmbGorevi
            // 
            cmbGorevi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGorevi.Font = new Font("Segoe UI", 11F);
            cmbGorevi.Location = new Point(219, 213);
            cmbGorevi.Margin = new Padding(3, 4, 3, 4);
            cmbGorevi.Name = "cmbGorevi";
            cmbGorevi.Size = new Size(278, 33);
            cmbGorevi.TabIndex = 9;
            // 
            // btnYeni
            // 
            btnYeni.BackColor = Color.Green;
            btnYeni.FlatAppearance.BorderSize = 0;
            btnYeni.FlatStyle = FlatStyle.Flat;
            btnYeni.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnYeni.ForeColor = Color.White;
            btnYeni.Location = new Point(67, 272);
            btnYeni.Margin = new Padding(3, 4, 3, 4);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(171, 56);
            btnYeni.TabIndex = 10;
            btnYeni.Text = "Yeni";
            btnYeni.UseVisualStyleBackColor = false;
            btnYeni.Click += btnYeni_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Navy;
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(246, 272);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(171, 56);
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Maroon;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(67, 336);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(171, 56);
            btnSil.TabIndex = 12;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.BackColor = Color.FromArgb(128, 128, 255);
            btnDegistir.FlatAppearance.BorderSize = 0;
            btnDegistir.FlatStyle = FlatStyle.Flat;
            btnDegistir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDegistir.ForeColor = Color.White;
            btnDegistir.Location = new Point(246, 336);
            btnDegistir.Margin = new Padding(3, 4, 3, 4);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(171, 56);
            btnDegistir.TabIndex = 13;
            btnDegistir.Text = "Değiştir";
            btnDegistir.UseVisualStyleBackColor = false;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(-1, 494);
            dgvUsers.Margin = new Padding(3, 4, 3, 4);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(905, 137);
            dgvUsers.TabIndex = 2;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = Color.FromArgb(80, 110, 0);
            btnYenile.FlatAppearance.BorderSize = 0;
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnYenile.ForeColor = Color.White;
            btnYenile.Location = new Point(-1, 1);
            btnYenile.Margin = new Padding(3, 4, 3, 4);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(53, 60);
            btnYenile.TabIndex = 1;
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
            btnKapat.Location = new Point(851, 1);
            btnKapat.Margin = new Padding(3, 4, 3, 4);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(53, 60);
            btnKapat.TabIndex = 0;
            btnKapat.Text = "\u23fb";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(903, 740);
            Controls.Add(btnKapat);
            Controls.Add(btnYenile);
            Controls.Add(dgvUsers);
            Controls.Add(pnlUserManagement);
            Controls.Add(pnlPasswordChange);
            Controls.Add(lblMevki);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistem Ayarları / Kullanıcı Yönetimi";
            Load += SettingsForm_Load;
            pnlPasswordChange.ResumeLayout(false);
            pnlPasswordChange.PerformLayout();
            pnlUserManagement.ResumeLayout(false);
            pnlUserManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
