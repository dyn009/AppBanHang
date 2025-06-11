using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBanHang.Database;

namespace AppBanHang.Views.Controls
{
    public partial class InfoOrderControl : UserControl
    {
        SqlDatabaseUsing data = new SqlDatabaseUsing();
        string IdOrder;
        public InfoOrderControl(string idOrder, string status, string price, string time, string formlity)
        {
            InitializeComponent();
            IdOrder = idOrder;
            lblOrder.Text = idOrder;
            lblStatus.Text = status;
            lblTotal.Text = price;
            lblTime.Text = time;
            if (string.Equals(status, "Delivered", StringComparison.OrdinalIgnoreCase))
            {
                btnDelivered.Enabled = false;
                btnDelivered.BackColor = Color.FromArgb(185, 185, 185);
            }
        }
        private void btnDelivered_Click(object sender, EventArgs e)
        {
            DataTable dt = data.GetData("update Bill set Status = 'Delivered' where ID = '" + IdOrder + "'");
            btnDelivered.Enabled = false;
            btnDelivered.BackColor = Color.FromArgb(185, 185, 185);
            lblStatus.Text = "Delivered";
        }

        private void InfoOrderControl_Load(object sender, EventArgs e)
        {
        }
    }
}
