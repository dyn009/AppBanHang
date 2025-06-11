using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanHang.Views.Controls
{
    public partial class ProductsOrderControl : UserControl
    {
        public string _Name { get; set; }
        public string _Size { get; set; }
        public int _Price { get; set; }
        public int _PriceM { get; set; }
        public int _PriceL { get; set; }
        public int _Quality { get; set; }
        public string _UpDown { get; set; }
        public int _Total { get; set; }
        public string _Cancel { get; set; }
        public ProductsOrderControl(string name, string price)
        {
            InitializeComponent();
            _Price = int.Parse(price);
            lblName.Text = name;
            lblPrice.Text = price;
        }
        public ProductsOrderControl()
        {
            InitializeComponent();

        }

        private void ProductsOrderControl_Load(object sender, EventArgs e)
        {
            _Name = lblName.Text;
            if (rbM.Checked)
            {
                _PriceM = _Price;
                _Size = "M";
                lblPrice.Text = _PriceM.ToString();
            }
            _Quality = 1;
            lblQality.Text = _Quality.ToString();
            ShowTotal();
        }

        private void rbM_CheckedChanged(object sender, EventArgs e)
        {
            _Size = "M";
            lblPrice.Text = _PriceM.ToString();
            ShowTotal();
        }

        private void rbL_CheckedChanged(object sender, EventArgs e)
        {
            _Size = "L";
            _PriceL = _PriceM + 15000;
            _Price = _PriceL;
            lblPrice.Text = _PriceL.ToString();
            ShowTotal();
        }

        private void lblCanccel_Click(object sender, EventArgs e)
        {
            if (this.Parent is FlowLayoutPanel panel)
            {
                panel.Controls.Remove(this);
            }
        }

        private void buttonControl2_Click(object sender, EventArgs e)
        {
            if(_Quality  > 0)
            {
                _Quality += -1;
                lblQality.Text = _Quality.ToString();
                ShowTotal();
            }
            
        }

        private void buttonControl1_Click(object sender, EventArgs e)
        {
            _Quality += 1;
            lblQality.Text = _Quality.ToString();
            ShowTotal();
        }

        private void ShowTotal()
        {
            if (rbM.Checked)
            {
                _Total = _Quality * _PriceM;
                lblTotal.Text = _Total.ToString();
            }
            else
            {
                _Total = _Quality*_PriceL;
                lblTotal.Text = _Total.ToString();
            }
        }
    }
}
