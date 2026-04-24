using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using RestaurantOtomasyon.Data;

namespace RestaurantOtomasyon
{
    public partial class frmRaporlar : Form
    {
        public frmRaporlar()
        {
            InitializeComponent();
        }

        
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen p = new Pen(Color.FromArgb(25, 255, 255, 255), 2))
            {
                g.DrawEllipse(p, this.Width - 150, -50, 200, 200);
                g.DrawEllipse(p, this.Width - 80, 50, 100, 100);
                g.DrawEllipse(p, this.Width - 200, 80, 80, 80);
                g.DrawEllipse(p, this.Width - 60, 180, 60, 60);

                g.DrawEllipse(p, -50, this.Height - 150, 180, 180);
                g.DrawEllipse(p, 50, this.Height - 80, 100, 100);

                g.DrawEllipse(p, this.Width / 2 - 100, this.Height / 2 - 50, 200, 200);
            }
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            
            string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran",
                               "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            cmbAy.Items.AddRange(aylar);
            cmbAy.SelectedIndex = DateTime.Now.Month - 1;

            
            for (int y = DateTime.Now.Year - 5; y <= DateTime.Now.Year + 1; y++)
            {
                cmbYil.Items.Add(y.ToString());
            }
            cmbYil.SelectedItem = DateTime.Now.Year.ToString();

            dgvRapor.CellPainting += dgvRapor_CellPainting;
        }

        private void btnAylikRapor_Click(object sender, EventArgs e)
        {
            if (cmbAy.SelectedIndex < 0 || cmbYil.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen ay ve yıl seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ay = cmbAy.SelectedIndex + 1;
            int yil = int.Parse(cmbYil.SelectedItem!.ToString()!);

            using (var context = new ApplicationDbContext())
            {
                var items = (from oi in context.OrderItems
                             join o in context.Orders on oi.OrderId equals o.Id
                             join p in context.Products on oi.ProductId equals p.Id
                             where o.OrderDate.Month == ay && o.OrderDate.Year == yil
                             orderby o.Id
                             let orderTotal = o.OrderItems.Sum(x => x.Price * x.Quantity)
                             let netTotal = orderTotal - o.DiscountAmount
                             select new RaporDto
                             {
                                 ORDERID = o.Id,
                                 ARATOPLAM = orderTotal,
                                 KDVTUTARI = netTotal > 0 ? netTotal * 0.08m : 0,
                                 INDIRIM = o.DiscountAmount,
                                 TOPLAMTUTAR = netTotal > 0 ? netTotal * 1.08m : 0,
                                 URUNAD = "⊞ " + p.Name,
                                 URUNID = p.Id,
                                 TARIH = o.OrderDate,
                                 IsGap = false
                             }).ToList();

                var rapor = new System.Collections.Generic.List<RaporDto>();
                for (int i = 0; i < items.Count; i++)
                {
                    rapor.Add(items[i]);
                    
                    if (i < items.Count - 1 && items[i].ORDERID != items[i + 1].ORDERID)
                    {
                        rapor.Add(new RaporDto { IsGap = true });
                    }
                }

                dgvRapor.DataSource = rapor;

                
                FormatColumns();

                
                decimal toplamAraToplam = rapor.Sum(r => r.ARATOPLAM ?? 0);
                decimal toplamKDV = rapor.Sum(r => r.KDVTUTARI ?? 0);
                decimal toplamGenel = rapor.Sum(r => r.TOPLAMTUTAR ?? 0);

                lblRaporBaslik.Text = $"AYLIK RAPOR - {cmbAy.SelectedItem} {yil}";
                lblToplamOzet.Text = $"Ara Toplam: {toplamAraToplam:N2} TL  |  KDV: {toplamKDV:N2} TL  |  Genel Toplam: {toplamGenel:N2} TL  |  Kayıt: {rapor.Count}";
            }
        }

        private void btnZRaporu_Click(object sender, EventArgs e)
        {
            
            DateTime bugun = DateTime.Today;

            using (var context = new ApplicationDbContext())
            {
                var items = (from oi in context.OrderItems
                             join o in context.Orders on oi.OrderId equals o.Id
                             join p in context.Products on oi.ProductId equals p.Id
                             where o.OrderDate.Date == bugun
                             orderby o.Id
                             let orderTotal = o.OrderItems.Sum(x => x.Price * x.Quantity)
                             let netTotal = orderTotal - o.DiscountAmount
                             select new RaporDto
                             {
                                 ORDERID = o.Id,
                                 ARATOPLAM = orderTotal,
                                 KDVTUTARI = netTotal > 0 ? netTotal * 0.08m : 0,
                                 INDIRIM = o.DiscountAmount,
                                 TOPLAMTUTAR = netTotal > 0 ? netTotal * 1.08m : 0,
                                 URUNAD = "⊞ " + p.Name,
                                 URUNID = p.Id,
                                 TARIH = o.OrderDate,
                                 IsGap = false
                             }).ToList();

                var rapor = new System.Collections.Generic.List<RaporDto>();
                for (int i = 0; i < items.Count; i++)
                {
                    rapor.Add(items[i]);
                    
                    if (i < items.Count - 1 && items[i].ORDERID != items[i + 1].ORDERID)
                    {
                        rapor.Add(new RaporDto { IsGap = true });
                    }
                }

                dgvRapor.DataSource = rapor;

                FormatColumns();

                decimal toplamAraToplam = rapor.Sum(r => r.ARATOPLAM ?? 0);
                decimal toplamKDV = rapor.Sum(r => r.KDVTUTARI ?? 0);
                decimal toplamGenel = rapor.Sum(r => r.TOPLAMTUTAR ?? 0);

                lblRaporBaslik.Text = $"Z RAPORU - {bugun:dd.MM.yyyy}";
                lblToplamOzet.Text = $"Ara Toplam: {toplamAraToplam:N2} TL  |  KDV: {toplamKDV:N2} TL  |  Genel Toplam: {toplamGenel:N2} TL  |  Kayıt: {rapor.Count}";
            }
        }

        private void FormatColumns()
        {
            if (dgvRapor.Columns.Contains("ORDERID"))
            {
                dgvRapor.Columns["ORDERID"].Visible = false;
            }
            if (dgvRapor.Columns.Contains("IsGap"))
            {
                dgvRapor.Columns["IsGap"].Visible = false;
            }
            if (dgvRapor.Columns.Contains("ARATOPLAM"))
            {
                dgvRapor.Columns["ARATOPLAM"].HeaderText = "ARATOPLAM";
                dgvRapor.Columns["ARATOPLAM"].DefaultCellStyle.Format = "N4";
                dgvRapor.Columns["ARATOPLAM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvRapor.Columns["ARATOPLAM"].DefaultCellStyle.BackColor = Color.FromArgb(168, 198, 238);
            }
            if (dgvRapor.Columns.Contains("KDVTUTARI"))
            {
                dgvRapor.Columns["KDVTUTARI"].HeaderText = "KDVTUTARI";
                dgvRapor.Columns["KDVTUTARI"].DefaultCellStyle.Format = "N4";
                dgvRapor.Columns["KDVTUTARI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvRapor.Columns["KDVTUTARI"].DefaultCellStyle.BackColor = Color.FromArgb(204, 226, 255);
            }
            if (dgvRapor.Columns.Contains("INDIRIM"))
            {
                dgvRapor.Columns["INDIRIM"].HeaderText = "INDIRIM";
                dgvRapor.Columns["INDIRIM"].DefaultCellStyle.Format = "N4";
                dgvRapor.Columns["INDIRIM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvRapor.Columns["INDIRIM"].DefaultCellStyle.BackColor = Color.FromArgb(235, 245, 255);
            }
            if (dgvRapor.Columns.Contains("TOPLAMTUTAR"))
            {
                dgvRapor.Columns["TOPLAMTUTAR"].HeaderText = "TOPLAMTUTAR";
                dgvRapor.Columns["TOPLAMTUTAR"].DefaultCellStyle.Format = "N4";
                dgvRapor.Columns["TOPLAMTUTAR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvRapor.Columns["TOPLAMTUTAR"].DefaultCellStyle.BackColor = Color.White;
            }
            if (dgvRapor.Columns.Contains("URUNAD"))
            {
                dgvRapor.Columns["URUNAD"].HeaderText = "URUNAD";
                dgvRapor.Columns["URUNAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvRapor.Columns["URUNAD"].DefaultCellStyle.ForeColor = Color.FromArgb(50, 80, 150);
                dgvRapor.Columns["URUNAD"].DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
            if (dgvRapor.Columns.Contains("URUNID"))
            {
                dgvRapor.Columns["URUNID"].HeaderText = "URUNID";
                dgvRapor.Columns["URUNID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvRapor.Columns.Contains("TARIH"))
            {
                dgvRapor.Columns["TARIH"].HeaderText = "TARIH";
                dgvRapor.Columns["TARIH"].DefaultCellStyle.Format = "dd.MM.yyyy\nHH:mm:ss";
                dgvRapor.Columns["TARIH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvRapor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(63, 106, 172);
            dgvRapor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRapor.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvRapor.EnableHeadersVisualStyles = false;
            dgvRapor.GridColor = Color.FromArgb(220, 220, 220);
            dgvRapor.RowTemplate.Height = 35;
        }

        private void dgvRapor_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var isGapCell = dgvRapor.Rows[e.RowIndex].Cells["IsGap"]?.Value as bool?;
            if (isGapCell == true)
            {
                
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(43, 43, 43)), e.CellBounds);
                e.Handled = true;
                return;
            }

            string colName = dgvRapor.Columns[e.ColumnIndex].Name;
            string[] colsToMerge = { "ARATOPLAM", "KDVTUTARI", "INDIRIM", "TOPLAMTUTAR", "TARIH" };

            if (!colsToMerge.Contains(colName)) return;

            bool isSameAsPrevious = false;
            bool isSameAsNext = false;

            if (e.RowIndex > 0)
            {
                var prevIsGap = dgvRapor.Rows[e.RowIndex - 1].Cells["IsGap"]?.Value as bool?;
                if (prevIsGap != true)
                {
                    var currentId = dgvRapor.Rows[e.RowIndex].Cells["ORDERID"].Value;
                    var prevId = dgvRapor.Rows[e.RowIndex - 1].Cells["ORDERID"].Value;
                    if (currentId != null && currentId.Equals(prevId))
                        isSameAsPrevious = true;
                }
            }

            if (e.RowIndex < dgvRapor.RowCount - 1)
            {
                var nextIsGap = dgvRapor.Rows[e.RowIndex + 1].Cells["IsGap"]?.Value as bool?;
                if (nextIsGap != true)
                {
                    var currentId = dgvRapor.Rows[e.RowIndex].Cells["ORDERID"].Value;
                    var nextId = dgvRapor.Rows[e.RowIndex + 1].Cells["ORDERID"].Value;
                    if (currentId != null && currentId.Equals(nextId))
                        isSameAsNext = true;
                }
            }

            
            e.PaintBackground(e.CellBounds, true);

            using (Pen gridPen = new Pen(dgvRapor.GridColor))
            {
                
                e.Graphics.DrawLine(gridPen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);

                
                if (!isSameAsNext)
                {
                    e.Graphics.DrawLine(gridPen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                }
            }

            
            if (!isSameAsPrevious)
            {
                Rectangle textBounds = e.CellBounds;
                textBounds.Inflate(-2, -2);

                
                textBounds.Y += 5;

                TextFormatFlags flags = TextFormatFlags.Top | TextFormatFlags.WordBreak;
                if (dgvRapor.Columns[e.ColumnIndex].DefaultCellStyle.Alignment == DataGridViewContentAlignment.MiddleRight)
                    flags |= TextFormatFlags.Right;
                else if (dgvRapor.Columns[e.ColumnIndex].DefaultCellStyle.Alignment == DataGridViewContentAlignment.MiddleCenter)
                    flags |= TextFormatFlags.HorizontalCenter;
                else
                    flags |= TextFormatFlags.Left;

                string formattedValue = e.FormattedValue?.ToString() ?? "";
                Color textColor = e.State.HasFlag(DataGridViewElementStates.Selected) ? e.CellStyle.SelectionForeColor : e.CellStyle.ForeColor;

                TextRenderer.DrawText(e.Graphics, formattedValue, e.CellStyle.Font, textBounds, textColor, flags);
            }

            e.Handled = true;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dgvRapor.DataSource = null;
            lblRaporBaslik.Text = "Rapor seçiniz...";
            lblToplamOzet.Text = "";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblYil_Click(object sender, EventArgs e)
        {

        }
    }

    public class RaporDto
    {
        public int? ORDERID { get; set; }
        public decimal? ARATOPLAM { get; set; }
        public decimal? KDVTUTARI { get; set; }
        public decimal? INDIRIM { get; set; }
        public decimal? TOPLAMTUTAR { get; set; }
        public string? URUNAD { get; set; }
        public int? URUNID { get; set; }
        public DateTime? TARIH { get; set; }
        public bool IsGap { get; set; }
    }
}
