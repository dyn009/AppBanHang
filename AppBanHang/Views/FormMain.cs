using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBanHang.Views.Controls;
using FontAwesome.Sharp;

namespace AppBanHang.Views
{
    public partial class FormMain : Form
    {
        private IconButton IconButton;
        string name = "lan";
        string doanh = "doanh";
        public FormMain()
        {
            InitializeComponent();
            //ShowHome();

            HomeControl homeControl = new HomeControl();
            addUserControl(homeControl);
            btnHome.BackColor = Color.BlueViolet;
            btnHome.ForeColor = Color.White;
            btnHome.IconColor = Color.White;
        }
        private void ShowHome()
        {
            btnHome.BackColor = Color.BlueViolet;
            btnHome.ForeColor = Color.White;
            btnHome.IconColor = Color.White;
            HomeControl homeControl = new HomeControl();
            addUserControl(homeControl);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblHeader.Text = "Home";
            HomeControl homeControl = new HomeControl();
            addUserControl(homeControl);

        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            ChangeColorHome();
            ActivateButton(sender);
            lblHeader.Text = "Sellings";
            SellingControl sellControl = new SellingControl();
            addUserControl(sellControl);
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            ChangeColorHome();
            ActivateButton(sender);
            lblHeader.Text = "Statistical";
            StatisticalsControl statisticalsControl = new StatisticalsControl();
            addUserControl(statisticalsControl);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ChangeColorHome();
            ActivateButton(sender);
            lblHeader.Text = "Products";
            ProductsControl productsControl = new ProductsControl();
            addUserControl(productsControl);
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            ChangeColorHome();
            ActivateButton(sender);
            lblHeader.Text = "Bills";
            BillsControl billsControl = new BillsControl();
            addUserControl(billsControl);
        }

        private void btnStaffs_Click(object sender, EventArgs e)
        {
            ChangeColorHome();
            ActivateButton(sender);
            lblHeader.Text = "Staffs";
            StaffsControl staffsControl = new StaffsControl();
            addUserControl(staffsControl);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ChangeColorHome();
            ActivateButton(sender);
            lblHeader.Text = "Customers";
            CustomersControl customersControl = new CustomersControl();
            addUserControl(customersControl);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ChangeColorHome();
            ActivateButton(sender);
            lblHeader.Text = "Sales";
            SalesControl salesControl = new SalesControl();
            addUserControl(salesControl);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                DisableButton();
                IconButton = (IconButton)sender;
                IconButton.BackColor = Color.BlueViolet;
                IconButton.ForeColor = Color.White;
                IconButton.IconColor = Color.White;
            }
        }

        private void DisableButton()
        {
            if (IconButton != null)
            {
                IconButton.BackColor = Color.White;
                IconButton.ForeColor = Color.Gray;
                IconButton.IconColor = Color.Gray;
            }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnShow.Controls.Clear();
            pnShow.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ChangeColorHome()
        {
            btnHome.BackColor = Color.White;
            btnHome.ForeColor = Color.DimGray;
            btnHome.IconColor = Color.DimGray;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
