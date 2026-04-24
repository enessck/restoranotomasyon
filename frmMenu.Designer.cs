namespace RestaurantOtomasyon
{
    partial class frmMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlDashboard;
        
        // Tiles
        private System.Windows.Forms.Button btnMasa;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.Button btnPaketServis;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnMutfak;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnKilitle;
        private System.Windows.Forms.Button btnCikis;

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
            lblUser = new Label();
            pnlDashboard = new Panel();
            btnMasa = new Button();
            btnRezervasyon = new Button();
            btnPaketServis = new Button();
            btnMusteriler = new Button();
            btnKasa = new Button();
            btnMutfak = new Button();
            btnRaporlar = new Button();
            btnAyarlar = new Button();
            btnKilitle = new Button();
            btnCikis = new Button();
            pnlDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Black;
            lblUser.Font = new Font("Segoe UI", 12F);
            lblUser.ForeColor = SystemColors.Control;
            lblUser.Location = new Point(57, 27);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(133, 28);
            lblUser.TabIndex = 2;
            lblUser.Text = "Kullanıcı: User";
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(btnMasa);
            pnlDashboard.Controls.Add(btnRezervasyon);
            pnlDashboard.Controls.Add(btnPaketServis);
            pnlDashboard.Controls.Add(btnMusteriler);
            pnlDashboard.Controls.Add(btnKasa);
            pnlDashboard.Controls.Add(btnMutfak);
            pnlDashboard.Controls.Add(btnRaporlar);
            pnlDashboard.Controls.Add(btnAyarlar);
            pnlDashboard.Controls.Add(btnKilitle);
            pnlDashboard.Controls.Add(btnCikis);
            pnlDashboard.Location = new Point(57, 80);
            pnlDashboard.Margin = new Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(583, 507);
            pnlDashboard.TabIndex = 1;
            // 
            // btnMasa
            // 
            btnMasa.BackColor = Color.FromArgb(0, 64, 64);
            btnMasa.FlatAppearance.BorderSize = 0;
            btnMasa.FlatStyle = FlatStyle.Flat;
            btnMasa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMasa.ForeColor = Color.White;
            btnMasa.Location = new Point(297, 173);
            btnMasa.Margin = new Padding(3, 4, 3, 4);
            btnMasa.Name = "btnMasa";
            btnMasa.Size = new Size(286, 160);
            btnMasa.TabIndex = 0;
            btnMasa.Text = "Masa";
            btnMasa.UseVisualStyleBackColor = false;
            btnMasa.Click += btnMasa_Click;
            // 
            // btnRezervasyon
            // 
            btnRezervasyon.BackColor = Color.FromArgb(255, 128, 128);
            btnRezervasyon.FlatAppearance.BorderSize = 0;
            btnRezervasyon.FlatStyle = FlatStyle.Flat;
            btnRezervasyon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRezervasyon.ForeColor = Color.White;
            btnRezervasyon.Location = new Point(0, 173);
            btnRezervasyon.Margin = new Padding(3, 4, 3, 4);
            btnRezervasyon.Name = "btnRezervasyon";
            btnRezervasyon.Size = new Size(137, 160);
            btnRezervasyon.TabIndex = 1;
            btnRezervasyon.Text = "Rezerve";
            btnRezervasyon.UseVisualStyleBackColor = false;
            btnRezervasyon.Click += btnRezervasyon_Click;
            // 
            // btnPaketServis
            // 
            btnPaketServis.BackColor = Color.FromArgb(128, 128, 255);
            btnPaketServis.FlatAppearance.BorderSize = 0;
            btnPaketServis.FlatStyle = FlatStyle.Flat;
            btnPaketServis.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPaketServis.ForeColor = Color.White;
            btnPaketServis.Location = new Point(446, 0);
            btnPaketServis.Margin = new Padding(3, 4, 3, 4);
            btnPaketServis.Name = "btnPaketServis";
            btnPaketServis.Size = new Size(137, 160);
            btnPaketServis.TabIndex = 2;
            btnPaketServis.Text = "Paket";
            btnPaketServis.UseVisualStyleBackColor = false;
            btnPaketServis.Click += btnNotImplemented_Click;
            // 
            // btnMusteriler
            // 
            btnMusteriler.BackColor = Color.FromArgb(255, 192, 128);
            btnMusteriler.FlatAppearance.BorderSize = 0;
            btnMusteriler.FlatStyle = FlatStyle.Flat;
            btnMusteriler.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMusteriler.ForeColor = Color.White;
            btnMusteriler.Location = new Point(297, 0);
            btnMusteriler.Margin = new Padding(3, 4, 3, 4);
            btnMusteriler.Name = "btnMusteriler";
            btnMusteriler.Size = new Size(137, 160);
            btnMusteriler.TabIndex = 3;
            btnMusteriler.Text = "Müşteri";
            btnMusteriler.UseVisualStyleBackColor = false;
            btnMusteriler.Click += btnMusteriler_Click;
            // 
            // btnKasa
            // 
            btnKasa.BackColor = Color.FromArgb(192, 255, 192);
            btnKasa.FlatAppearance.BorderSize = 0;
            btnKasa.FlatStyle = FlatStyle.Flat;
            btnKasa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKasa.ForeColor = Color.White;
            btnKasa.Location = new Point(149, 173);
            btnKasa.Margin = new Padding(3, 4, 3, 4);
            btnKasa.Name = "btnKasa";
            btnKasa.Size = new Size(137, 160);
            btnKasa.TabIndex = 4;
            btnKasa.Text = "Kasa";
            btnKasa.UseVisualStyleBackColor = false;
            btnKasa.Click += btnKasa_Click;
            // 
            // btnMutfak
            // 
            btnMutfak.BackColor = Color.FromArgb(255, 192, 192);
            btnMutfak.FlatAppearance.BorderSize = 0;
            btnMutfak.FlatStyle = FlatStyle.Flat;
            btnMutfak.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMutfak.ForeColor = Color.White;
            btnMutfak.Location = new Point(0, 0);
            btnMutfak.Margin = new Padding(3, 4, 3, 4);
            btnMutfak.Name = "btnMutfak";
            btnMutfak.Size = new Size(286, 160);
            btnMutfak.TabIndex = 5;
            btnMutfak.Text = "Mutfak";
            btnMutfak.UseVisualStyleBackColor = false;
            btnMutfak.Click += btnMutfak_Click;
            // 
            // btnRaporlar
            // 
            btnRaporlar.BackColor = Color.FromArgb(64, 64, 64);
            btnRaporlar.FlatAppearance.BorderSize = 0;
            btnRaporlar.FlatStyle = FlatStyle.Flat;
            btnRaporlar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRaporlar.ForeColor = Color.White;
            btnRaporlar.Location = new Point(0, 347);
            btnRaporlar.Margin = new Padding(3, 4, 3, 4);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(137, 160);
            btnRaporlar.TabIndex = 6;
            btnRaporlar.Text = "Raporlar";
            btnRaporlar.UseVisualStyleBackColor = false;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BackColor = Color.FromArgb(128, 64, 0);
            btnAyarlar.FlatAppearance.BorderSize = 0;
            btnAyarlar.FlatStyle = FlatStyle.Flat;
            btnAyarlar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAyarlar.ForeColor = Color.White;
            btnAyarlar.Location = new Point(149, 347);
            btnAyarlar.Margin = new Padding(3, 4, 3, 4);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(137, 160);
            btnAyarlar.TabIndex = 7;
            btnAyarlar.Text = "Ayarlar";
            btnAyarlar.UseVisualStyleBackColor = false;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // btnKilitle
            // 
            btnKilitle.BackColor = Color.FromArgb(192, 0, 0);
            btnKilitle.FlatAppearance.BorderSize = 0;
            btnKilitle.FlatStyle = FlatStyle.Flat;
            btnKilitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKilitle.ForeColor = Color.White;
            btnKilitle.Location = new Point(297, 347);
            btnKilitle.Margin = new Padding(3, 4, 3, 4);
            btnKilitle.Name = "btnKilitle";
            btnKilitle.Size = new Size(137, 160);
            btnKilitle.TabIndex = 8;
            btnKilitle.Text = "Kilit";
            btnKilitle.UseVisualStyleBackColor = false;
            btnKilitle.Click += btnNotImplemented_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Silver;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(446, 347);
            btnCikis.Margin = new Padding(3, 4, 3, 4);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(137, 160);
            btnCikis.TabIndex = 9;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(697, 640);
            Controls.Add(pnlDashboard);
            Controls.Add(lblUser);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Menü";
            Load += DashboardForm_Load;
            pnlDashboard.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
