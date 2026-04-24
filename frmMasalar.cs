using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using RestaurantOtomasyon.Data;
using RestaurantOtomasyon.Models;
using RestaurantOtomasyon.Controls;

namespace RestaurantOtomasyon
{
    public partial class frmMasalar : Form
    {
        private readonly User _currentUser;
        private List<TableButton> _tableButtons = new List<TableButton>();

        public frmMasalar(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;

            
            this.BackColor = Color.FromArgb(43, 43, 43);

            
            _tableButtons = new List<TableButton> 
            { 
                btnMasa1, btnMasa2, btnMasa3, btnMasa4, btnMasa5, 
                btnMasa6, btnMasa7, btnMasa8, btnMasa9, btnMasa10 
            };

            foreach (var btn in _tableButtons)
            {
                btn.Click += BtnTable_Click;
            }
        }

        
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen p = new Pen(Color.FromArgb(25, 255, 255, 255), 2))
            {
                
                g.DrawEllipse(p, 150, -50, 150, 150);
                g.DrawEllipse(p, 100, 30, 80, 80);
                g.DrawEllipse(p, 230, 80, 120, 120);
                g.DrawEllipse(p, 330, -20, 180, 180);
                g.DrawEllipse(p, 450, 100, 90, 90);
                g.DrawEllipse(p, 650, -40, 130, 130);
                g.DrawEllipse(p, 750, 80, 70, 70);
            }
        }

        private void TablesForm_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;
            LoadTables();
        }

        private void LoadTables()
        {
            using (var context = new ApplicationDbContext())
            {
                var tables = context.RestaurantTables.OrderBy(t => t.Id).Take(10).ToList();
                var activeOrders = context.Orders.Where(o => !o.IsCompleted).ToList();

                for (int i = 0; i < tables.Count; i++)
                {
                    if (i >= _tableButtons.Count) break;

                    var table = tables[i];
                    var btn = _tableButtons[i];

                    DateTime? orderStartTime = null;
                    if (table.Status == TableStatus.Occupied)
                    {
                        var order = activeOrders.FirstOrDefault(o => o.RestaurantTableId == table.Id);
                        if (order != null)
                        {
                            orderStartTime = order.OrderDate;
                        }
                    }

                    
                    btn.Tag = table.Id;
                    btn.Text = table.Name;
                    btn.Status = table.Status;
                    btn.OrderStartTime = orderStartTime;
                    
                    
                    switch (table.Status)
                    {
                        case TableStatus.Empty:
                            btn.BackColor = Color.FromArgb(164, 198, 57); 
                            break;
                        case TableStatus.Occupied:
                            btn.BackColor = Color.Red;
                            break;
                        case TableStatus.Reserved:
                            btn.BackColor = Color.FromArgb(218, 108, 62);
                            break;
                        default:
                            btn.BackColor = Color.Gray;
                            break;
                    }
                    
                    
                    btn.Invalidate();
                }
            }
        }

        private void BtnTable_Click(object sender, EventArgs e)
        {
            if (sender is TableButton btn && btn.Tag is int tableId)
            {
                var frmOrder = new frmPaketSiparis(tableId, _currentUser);
                frmOrder.FormClosed += (s, args) => LoadTables();
                frmOrder.Show();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            LoadTables();
        }
    }
}
