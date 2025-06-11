using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanHang.Views.Controls.Statisticals
{
    public partial class BillQuality : UserControl
    {
        public BillQuality(string id, string time, string money)
        {
            InitializeComponent();
            txtIdBill.Text = id;
            txtTime.Text = time;
            txtIntoMoney.Text = money;
        }
    }
}
