namespace RestaurantOtomasyon
{
    partial class frmGiris
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlLogoBox;
        private System.Windows.Forms.Label lblLogoDakimasu;

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
            cmbUsername = new ComboBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            pnlLogoBox = new Panel();
            lblLogoDakimasu = new Label();
            pnlLogoBox.SuspendLayout();
            SuspendLayout();
            // 
            // cmbUsername
            // 
            cmbUsername.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsername.Font = new Font("Segoe UI", 14F);
            cmbUsername.FormattingEnabled = true;
            cmbUsername.Location = new Point(314, 133);
            cmbUsername.Margin = new Padding(3, 4, 3, 4);
            cmbUsername.Name = "cmbUsername";
            cmbUsername.Size = new Size(340, 39);
            cmbUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.Location = new Point(314, 195);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(340, 39);
            txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 192, 192);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(316, 255);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 67);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "☑  GİRİŞ";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Black;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(379, 342);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(74, 67);
            btnExit.TabIndex = 6;
            btnExit.Text = "\u23fb";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.Crimson;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsername.ForeColor = Color.Transparent;
            lblUsername.Location = new Point(92, 133);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(171, 44);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Kullanıcı Adı";
            lblUsername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            lblPassword.BackColor = Color.Crimson;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPassword.ForeColor = Color.Transparent;
            lblPassword.Location = new Point(92, 195);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(171, 43);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Şifre";
            lblPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlLogoBox
            // 
            pnlLogoBox.BackColor = Color.White;
            pnlLogoBox.Controls.Add(lblLogoDakimasu);
            pnlLogoBox.Location = new Point(196, 31);
            pnlLogoBox.Margin = new Padding(3, 4, 3, 4);
            pnlLogoBox.Name = "pnlLogoBox";
            pnlLogoBox.Size = new Size(379, 73);
            pnlLogoBox.TabIndex = 0;
            // 
            // lblLogoDakimasu
            // 
            lblLogoDakimasu.AutoSize = true;
            lblLogoDakimasu.BackColor = Color.White;
            lblLogoDakimasu.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            lblLogoDakimasu.ForeColor = Color.FromArgb(128, 64, 64);
            lblLogoDakimasu.Location = new Point(26, 14);
            lblLogoDakimasu.Name = "lblLogoDakimasu";
            lblLogoDakimasu.Size = new Size(334, 41);
            lblLogoDakimasu.TabIndex = 1;
            lblLogoDakimasu.Text = "restorant otomasyonu";
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(739, 515);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(cmbUsername);
            Controls.Add(lblUsername);
            Controls.Add(pnlLogoBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Akıllı Restoran Sistemi - Giriş Ekrani";
            Load += LoginForm_Load;
            pnlLogoBox.ResumeLayout(false);
            pnlLogoBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
