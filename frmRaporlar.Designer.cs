namespace RestaurantOtomasyon
{
    partial class frmRaporlar
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnAylikRapor;
        private System.Windows.Forms.Button btnZRaporu;
        private System.Windows.Forms.DataGridView dgvRapor;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.ComboBox cmbYil;
        private System.Windows.Forms.Label lblAy;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Label lblRaporBaslik;
        private System.Windows.Forms.Label lblToplamOzet;
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
            btnAylikRapor = new Button();
            btnZRaporu = new Button();
            dgvRapor = new DataGridView();
            pnlToolbar = new Panel();
            lblAy = new Label();
            cmbAy = new ComboBox();
            lblYil = new Label();
            cmbYil = new ComboBox();
            lblRaporBaslik = new Label();
            lblToplamOzet = new Label();
            btnYenile = new Button();
            btnKapat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).BeginInit();
            pnlToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // btnAylikRapor
            // 
            btnAylikRapor.BackColor = Color.FromArgb(255, 192, 128);
            btnAylikRapor.FlatAppearance.BorderSize = 0;
            btnAylikRapor.FlatStyle = FlatStyle.Flat;
            btnAylikRapor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAylikRapor.ForeColor = Color.White;
            btnAylikRapor.Location = new Point(12, 208);
            btnAylikRapor.Name = "btnAylikRapor";
            btnAylikRapor.Size = new Size(170, 80);
            btnAylikRapor.TabIndex = 0;
            btnAylikRapor.Text = "AYLIK\r\nRAPOR";
            btnAylikRapor.UseVisualStyleBackColor = false;
            btnAylikRapor.Click += btnAylikRapor_Click;
            // 
            // btnZRaporu
            // 
            btnZRaporu.BackColor = Color.FromArgb(0, 192, 192);
            btnZRaporu.FlatAppearance.BorderSize = 0;
            btnZRaporu.FlatStyle = FlatStyle.Flat;
            btnZRaporu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnZRaporu.ForeColor = Color.White;
            btnZRaporu.Location = new Point(12, 294);
            btnZRaporu.Name = "btnZRaporu";
            btnZRaporu.Size = new Size(170, 80);
            btnZRaporu.TabIndex = 1;
            btnZRaporu.Text = "Z\r\nRAPORU";
            btnZRaporu.UseVisualStyleBackColor = false;
            btnZRaporu.Click += btnZRaporu_Click;
            // 
            // dgvRapor
            // 
            dgvRapor.AllowUserToAddRows = false;
            dgvRapor.AllowUserToDeleteRows = false;
            dgvRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRapor.BackgroundColor = Color.White;
            dgvRapor.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 80, 150);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRapor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRapor.ColumnHeadersHeight = 38;
            dgvRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(70, 100, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRapor.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRapor.EnableHeadersVisualStyles = false;
            dgvRapor.Location = new Point(195, 96);
            dgvRapor.Name = "dgvRapor";
            dgvRapor.ReadOnly = true;
            dgvRapor.RowHeadersVisible = false;
            dgvRapor.RowHeadersWidth = 51;
            dgvRapor.RowTemplate.Height = 32;
            dgvRapor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRapor.Size = new Size(761, 442);
            dgvRapor.TabIndex = 4;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.FromArgb(128, 128, 255);
            pnlToolbar.Controls.Add(lblAy);
            pnlToolbar.Controls.Add(cmbAy);
            pnlToolbar.Controls.Add(lblYil);
            pnlToolbar.Controls.Add(cmbYil);
            pnlToolbar.Location = new Point(12, 10);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(745, 40);
            pnlToolbar.TabIndex = 2;
            // 
            // lblAy
            // 
            lblAy.AutoSize = true;
            lblAy.BackColor = Color.FromArgb(255, 128, 128);
            lblAy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAy.ForeColor = Color.White;
            lblAy.Location = new Point(10, 8);
            lblAy.Name = "lblAy";
            lblAy.Size = new Size(36, 23);
            lblAy.TabIndex = 0;
            lblAy.Text = "Ay:";
            // 
            // cmbAy
            // 
            cmbAy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAy.Font = new Font("Segoe UI", 10F);
            cmbAy.Location = new Point(54, 5);
            cmbAy.Name = "cmbAy";
            cmbAy.Size = new Size(207, 31);
            cmbAy.TabIndex = 1;
            // 
            // lblYil
            // 
            lblYil.AutoSize = true;
            lblYil.BackColor = Color.FromArgb(255, 128, 128);
            lblYil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblYil.ForeColor = Color.White;
            lblYil.Location = new Point(298, 8);
            lblYil.Name = "lblYil";
            lblYil.Size = new Size(35, 23);
            lblYil.TabIndex = 2;
            lblYil.Text = "Yıl:";
            lblYil.Click += lblYil_Click;
            // 
            // cmbYil
            // 
            cmbYil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYil.Font = new Font("Segoe UI", 10F);
            cmbYil.Location = new Point(339, 5);
            cmbYil.Name = "cmbYil";
            cmbYil.Size = new Size(168, 31);
            cmbYil.TabIndex = 3;
            // 
            // lblRaporBaslik
            // 
            lblRaporBaslik.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblRaporBaslik.ForeColor = Color.Lime;
            lblRaporBaslik.Location = new Point(195, 58);
            lblRaporBaslik.Name = "lblRaporBaslik";
            lblRaporBaslik.Size = new Size(745, 35);
            lblRaporBaslik.TabIndex = 3;
            lblRaporBaslik.Text = "Rapor seçiniz...";
            lblRaporBaslik.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblToplamOzet
            // 
            lblToplamOzet.BackColor = Color.FromArgb(0, 64, 0);
            lblToplamOzet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblToplamOzet.ForeColor = Color.FromArgb(128, 255, 128);
            lblToplamOzet.Location = new Point(-1, 541);
            lblToplamOzet.Name = "lblToplamOzet";
            lblToplamOzet.Size = new Size(980, 35);
            lblToplamOzet.TabIndex = 5;
            lblToplamOzet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = Color.FromArgb(64, 0, 64);
            btnYenile.FlatAppearance.BorderSize = 0;
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnYenile.ForeColor = Color.White;
            btnYenile.Location = new Point(829, 7);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(65, 63);
            btnYenile.TabIndex = 6;
            btnYenile.Text = "↻";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.Black;
            btnKapat.FlatAppearance.BorderSize = 0;
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnKapat.ForeColor = Color.White;
            btnKapat.Location = new Point(900, 7);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(67, 63);
            btnKapat.TabIndex = 7;
            btnKapat.Text = "\u23fb";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // frmRaporlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(979, 575);
            Controls.Add(btnKapat);
            Controls.Add(btnYenile);
            Controls.Add(lblToplamOzet);
            Controls.Add(dgvRapor);
            Controls.Add(lblRaporBaslik);
            Controls.Add(pnlToolbar);
            Controls.Add(btnZRaporu);
            Controls.Add(btnAylikRapor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmRaporlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış Raporları ve Kasa";
            Load += RaporForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRapor).EndInit();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            ResumeLayout(false);
        }
    }
}
