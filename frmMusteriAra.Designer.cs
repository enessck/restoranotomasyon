namespace RestaurantOtomasyon
{
    partial class frmMusteriAra
    {
        private System.ComponentModel.IContainer components = null;

        // Top search fields
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblAdisyonId;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtAdisyonId;

        // Data grid
        private System.Windows.Forms.DataGridView dgvCustomers;

        // Right side display & buttons
        private System.Windows.Forms.TextBox txtDetailBox;
        private System.Windows.Forms.Button btnAdisyonBul;
        private System.Windows.Forms.Button btnYenile;

        // Bottom buttons
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnSiparisler;

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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblAdi = new Label();
            lblSoyadi = new Label();
            lblTelefon = new Label();
            lblAdres = new Label();
            lblEMail = new Label();
            lblAdisyonId = new Label();
            txtAdi = new TextBox();
            txtSoyadi = new TextBox();
            txtTelefon = new TextBox();
            txtAdres = new TextBox();
            txtEMail = new TextBox();
            txtAdisyonId = new TextBox();
            dgvCustomers = new DataGridView();
            btnAdisyonBul = new Button();
            btnYenile = new Button();
            btnYeniMusteri = new Button();
            btnMusteriSec = new Button();
            btnMusteriGuncelle = new Button();
            btnSiparisler = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblAdi
            // 
            lblAdi.AutoSize = true;
            lblAdi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAdi.ForeColor = Color.Black;
            lblAdi.Location = new Point(70, 13);
            lblAdi.Name = "lblAdi";
            lblAdi.Size = new Size(37, 25);
            lblAdi.TabIndex = 0;
            lblAdi.Text = "Ad";
            // 
            // lblSoyadi
            // 
            lblSoyadi.AutoSize = true;
            lblSoyadi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSoyadi.ForeColor = Color.Black;
            lblSoyadi.Location = new Point(223, 13);
            lblSoyadi.Name = "lblSoyadi";
            lblSoyadi.Size = new Size(67, 25);
            lblSoyadi.TabIndex = 1;
            lblSoyadi.Text = "Soyad";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTelefon.ForeColor = Color.Black;
            lblTelefon.Location = new Point(366, 13);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(77, 25);
            lblTelefon.TabIndex = 2;
            lblTelefon.Text = "Telefon";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAdres.ForeColor = Color.Black;
            lblAdres.Location = new Point(780, 13);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(63, 25);
            lblAdres.TabIndex = 3;
            lblAdres.Text = "Adres";
            lblAdres.Click += lblAdres_Click;
            // 
            // lblEMail
            // 
            lblEMail.AutoSize = true;
            lblEMail.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEMail.ForeColor = Color.Black;
            lblEMail.Location = new Point(509, 13);
            lblEMail.Name = "lblEMail";
            lblEMail.Size = new Size(77, 25);
            lblEMail.TabIndex = 4;
            lblEMail.Text = "E-MAİL";
            // 
            // lblAdisyonId
            // 
            lblAdisyonId.AutoSize = true;
            lblAdisyonId.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAdisyonId.ForeColor = Color.Black;
            lblAdisyonId.Location = new Point(652, 13);
            lblAdisyonId.Name = "lblAdisyonId";
            lblAdisyonId.Size = new Size(84, 25);
            lblAdisyonId.TabIndex = 5;
            lblAdisyonId.Text = "Adisyon";
            lblAdisyonId.Click += lblAdisyonId_Click;
            // 
            // txtAdi
            // 
            txtAdi.Font = new Font("Segoe UI", 10F);
            txtAdi.Location = new Point(80, 47);
            txtAdi.Margin = new Padding(3, 4, 3, 4);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(137, 30);
            txtAdi.TabIndex = 6;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Font = new Font("Segoe UI", 10F);
            txtSoyadi.Location = new Point(223, 47);
            txtSoyadi.Margin = new Padding(3, 4, 3, 4);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(137, 30);
            txtSoyadi.TabIndex = 7;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Segoe UI", 10F);
            txtTelefon.Location = new Point(366, 47);
            txtTelefon.Margin = new Padding(3, 4, 3, 4);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(137, 30);
            txtTelefon.TabIndex = 8;
            // 
            // txtAdres
            // 
            txtAdres.Font = new Font("Segoe UI", 10F);
            txtAdres.Location = new Point(780, 47);
            txtAdres.Margin = new Padding(3, 4, 3, 4);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(151, 30);
            txtAdres.TabIndex = 9;
            // 
            // txtEMail
            // 
            txtEMail.Font = new Font("Segoe UI", 10F);
            txtEMail.Location = new Point(509, 47);
            txtEMail.Margin = new Padding(3, 4, 3, 4);
            txtEMail.Name = "txtEMail";
            txtEMail.Size = new Size(137, 30);
            txtEMail.TabIndex = 10;
            // 
            // txtAdisyonId
            // 
            txtAdisyonId.Font = new Font("Segoe UI", 10F);
            txtAdisyonId.Location = new Point(652, 47);
            txtAdisyonId.Margin = new Padding(3, 4, 3, 4);
            txtAdisyonId.Name = "txtAdisyonId";
            txtAdisyonId.Size = new Size(122, 30);
            txtAdisyonId.TabIndex = 11;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomers.Location = new Point(132, 85);
            dgvCustomers.Margin = new Padding(3, 4, 3, 4);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(652, 337);
            dgvCustomers.TabIndex = 12;
            // 
            // btnAdisyonBul
            // 
            btnAdisyonBul.BackColor = Color.FromArgb(192, 192, 255);
            btnAdisyonBul.FlatAppearance.BorderSize = 0;
            btnAdisyonBul.FlatStyle = FlatStyle.Flat;
            btnAdisyonBul.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdisyonBul.ForeColor = Color.White;
            btnAdisyonBul.Location = new Point(-4, 187);
            btnAdisyonBul.Margin = new Padding(3, 4, 3, 4);
            btnAdisyonBul.Name = "btnAdisyonBul";
            btnAdisyonBul.Size = new Size(141, 97);
            btnAdisyonBul.TabIndex = 14;
            btnAdisyonBul.Text = "🔍 ADİSYON\n     BUL";
            btnAdisyonBul.UseVisualStyleBackColor = false;
            btnAdisyonBul.Click += btnAdisyonBul_Click;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = Color.FromArgb(255, 128, 128);
            btnYenile.FlatAppearance.BorderSize = 0;
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            btnYenile.ForeColor = Color.White;
            btnYenile.Location = new Point(780, 205);
            btnYenile.Margin = new Padding(3, 4, 3, 4);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(166, 91);
            btnYenile.TabIndex = 15;
            btnYenile.Text = "←";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnYeniMusteri
            // 
            btnYeniMusteri.BackColor = Color.Navy;
            btnYeniMusteri.FlatAppearance.BorderSize = 0;
            btnYeniMusteri.FlatStyle = FlatStyle.Flat;
            btnYeniMusteri.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnYeniMusteri.ForeColor = Color.White;
            btnYeniMusteri.Location = new Point(716, 433);
            btnYeniMusteri.Margin = new Padding(3, 4, 3, 4);
            btnYeniMusteri.Name = "btnYeniMusteri";
            btnYeniMusteri.Size = new Size(223, 73);
            btnYeniMusteri.TabIndex = 16;
            btnYeniMusteri.Text = "👤 Yeni Müşteri";
            btnYeniMusteri.UseVisualStyleBackColor = false;
            btnYeniMusteri.Click += btnYeniMusteri_Click;
            // 
            // btnMusteriSec
            // 
            btnMusteriSec.BackColor = Color.FromArgb(255, 192, 128);
            btnMusteriSec.FlatAppearance.BorderSize = 0;
            btnMusteriSec.FlatStyle = FlatStyle.Flat;
            btnMusteriSec.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnMusteriSec.ForeColor = Color.White;
            btnMusteriSec.Location = new Point(24, 433);
            btnMusteriSec.Margin = new Padding(3, 4, 3, 4);
            btnMusteriSec.Name = "btnMusteriSec";
            btnMusteriSec.Size = new Size(209, 73);
            btnMusteriSec.TabIndex = 17;
            btnMusteriSec.Text = "☑ Müşteri Seç";
            btnMusteriSec.UseVisualStyleBackColor = false;
            btnMusteriSec.Click += btnMusteriSec_Click;
            // 
            // btnMusteriGuncelle
            // 
            btnMusteriGuncelle.BackColor = Color.FromArgb(255, 128, 0);
            btnMusteriGuncelle.FlatAppearance.BorderSize = 0;
            btnMusteriGuncelle.FlatStyle = FlatStyle.Flat;
            btnMusteriGuncelle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnMusteriGuncelle.ForeColor = Color.White;
            btnMusteriGuncelle.Location = new Point(232, 433);
            btnMusteriGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            btnMusteriGuncelle.Size = new Size(246, 73);
            btnMusteriGuncelle.TabIndex = 18;
            btnMusteriGuncelle.Text = "↻ Müşteri Güncelle";
            btnMusteriGuncelle.UseVisualStyleBackColor = false;
            btnMusteriGuncelle.Click += btnMusteriGuncelle_Click;
            // 
            // btnSiparisler
            // 
            btnSiparisler.BackColor = Color.FromArgb(0, 192, 192);
            btnSiparisler.FlatAppearance.BorderSize = 0;
            btnSiparisler.FlatStyle = FlatStyle.Flat;
            btnSiparisler.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSiparisler.ForeColor = Color.White;
            btnSiparisler.Location = new Point(473, 433);
            btnSiparisler.Margin = new Padding(3, 4, 3, 4);
            btnSiparisler.Name = "btnSiparisler";
            btnSiparisler.Size = new Size(247, 73);
            btnSiparisler.TabIndex = 19;
            btnSiparisler.Text = "📋 Siparişler";
            btnSiparisler.UseVisualStyleBackColor = false;
            btnSiparisler.Click += btnSiparisler_Click;
            // 
            // frmMusteriAra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(943, 527);
            Controls.Add(lblAdi);
            Controls.Add(lblSoyadi);
            Controls.Add(lblTelefon);
            Controls.Add(lblAdres);
            Controls.Add(lblEMail);
            Controls.Add(lblAdisyonId);
            Controls.Add(txtAdi);
            Controls.Add(txtSoyadi);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdres);
            Controls.Add(txtEMail);
            Controls.Add(txtAdisyonId);
            Controls.Add(dgvCustomers);
            Controls.Add(btnAdisyonBul);
            Controls.Add(btnYenile);
            Controls.Add(btnYeniMusteri);
            Controls.Add(btnMusteriSec);
            Controls.Add(btnMusteriGuncelle);
            Controls.Add(btnSiparisler);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMusteriAra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Kayıtları";
            Load += CustomersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
