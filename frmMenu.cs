using System;
using System.Drawing;
using System.Windows.Forms;
using RestaurantOtomasyon.Models;

namespace RestaurantOtomasyon
{
    public partial class frmMenu : Form
    {
        private readonly User _currentUser;

        public frmMenu(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            SetMetroStyle();
        }

        private void SetMetroStyle()
        {
            this.BackColor = Color.FromArgb(30, 40, 55);
            this.ForeColor = Color.White;
        }


        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = $"Kullanıcı: {_currentUser.Username}";
        }

        private void btnMasa_Click(object sender, EventArgs e)
        {
            var frm = new frmMasalar(_currentUser);
            frm.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            var frm = new frmMusteriAra();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            var login = new frmGiris();
            login.Show();
            this.Close();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            var frm = new frmSettings(_currentUser);
            frm.Show();
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            var frm = new frmMutfak();
            frm.Show();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            var frm = new frmRaporlar();
            frm.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            var frm = new SatisRaporlariForm();
            frm.Show();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            var frm = new frmRezervarsyon(_currentUser);
            frm.Show();
        }

        
        private void btnNotImplemented_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu modül şu anda aktif değil.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
