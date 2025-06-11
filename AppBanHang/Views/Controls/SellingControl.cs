using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using AppBanHang.Database;
using AppBanHang.Models;
using FontAwesome.Sharp;
using static System.Windows.Forms.AxHost;

namespace AppBanHang.Views.Controls
{
    public partial class SellingControl : UserControl
    {
        List<ProductModel> lstProduct = new List<ProductModel>();
        List<BillModdel> lstBillModdels = new List<BillModdel>();
        BillModdel bill;
        SqlDatabaseUsing data = new SqlDatabaseUsing();
        DateTime dateTime = DateTime.Now;
        string formality = "";
        string listOrder = "";
        string idOrder = "";
        string strDate;
        public SellingControl()
        {
            InitializeComponent();
            ShowListOrdered();
        }

        private void btnAddOrderBring_Click(object sender, EventArgs e)
        {
            btnAddOrderBring.Enabled = false;
            btnAddOrderInShop.Enabled = false;
            formality = "Bring";
            ShowInOrder();
        }
        private void btnAddOrderInShop_Click(object sender, EventArgs e)
        {
            btnAddOrderBring.Enabled = false;
            btnAddOrderInShop.Enabled = false;
            formality = "At The Shop";
            ShowInOrder();
        }
        private void btnToPay_Click(object sender, EventArgs e)
        {
            ShowPay();
        }
        private void btnPayInMoney_Click(object sender, EventArgs e)
        {
            int countBill = data.GetData("select * from Bill where ID like '%" + strDate + "%'").Rows.Count; 
            idOrder = strDate + (countBill + 1).ToString();
            bill = new BillModdel() { Id = idOrder, listOrder = AddListOrder(idOrder), CustomerCode = "", TableOrder = 2, 
                Date = dateTime.ToString("ddMMyy HH:mm:ss"), IntoMoney = int.Parse(lblIntoMoney.Text), Status = "Chưa giao", Formality = formality, Total = int.Parse(lblTotal.Text)};
            if (data.InsertBill(bill))
            {
                MessageBox.Show("Ok");
            }
            flpProductOrder.Controls.Clear();
            loOrder.Visible = false;
            btnAddOrderBring.Enabled = true;
            btnAddOrderInShop.Enabled = true;
            ShowListOrdered();
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void ShowListOrdered()
        {
            flpListOrder.Controls.Clear();
            DataTable dt = new DataTable();
            strDate = dateTime.ToString("ddMMyyyy");
            dt = data.GetData("select * from Bill where ID like '%"+ strDate +"%'");
            foreach(DataRow row in dt.Rows)
            {
                InfoOrderControl infoOrder = new InfoOrderControl(row[0].ToString(), row[5].ToString(), row[4].ToString(), row[3].ToString(), row[6].ToString());
                flpListOrder.Controls.Add(infoOrder);
            }
        }
        private List<ListOrder> AddListOrder(string IDOrder)
        {
            List<ListOrder> listOrders = new List<ListOrder>();
            foreach (ListViewItem item in lvBill.Items)
            {

                ListOrder order = new ListOrder() {IdOrder = IDOrder, Name = item.SubItems[0].Text, Size = item.SubItems[1].Text, Price = int.Parse(item.SubItems[2].Text), 
                    Quality = int.Parse(item.SubItems[3].Text), Total = int.Parse(item.SubItems[4].Text) };
                listOrders.Add(order);
            }
            return listOrders;
        }
        private void ShowPay()
        {
            int inToMoney = 0;
            loOrder.Panel2.Visible = true;
            BillModdel billModdel;
            lvBill.Items.Clear();
            foreach (Control control in flpProductOrder.Controls)
            {
                if (control is ProductsOrderControl productsOrder)
                {
                    ListViewItem listViewItem = new ListViewItem(productsOrder._Name);
                    listViewItem.SubItems.Add(productsOrder._Size);
                    listViewItem.SubItems.Add(productsOrder._Price.ToString());
                    listViewItem.SubItems.Add(productsOrder._Quality.ToString());
                    listViewItem.SubItems.Add((productsOrder._Price * productsOrder._Quality).ToString());
                    lvBill.Items.Add(listViewItem);
                    inToMoney += productsOrder._Price * productsOrder._Quality;
                }
            }

            lblIntoMoney.Text = inToMoney.ToString();
            lblVAT.Text = (inToMoney * 5 / 100).ToString();
            lblService.Text = (inToMoney * 1 / 100).ToString();
            //lblDiscount.Text = cbDiscount.SelectedIndex.ToString();
            lblTotal.Text = (inToMoney + inToMoney * 5 / 100 + inToMoney * 1 / 100).ToString();
        }
        private void ShowInOrder()
        {
            loOrder.Panel2.Visible = false;
            loOrder.Visible = true;
            ShowMenu();
        }
        private void ShowMenu()
        {
            DataTable dt = data.GetData("select * from TypeProduct");
            foreach (DataRow row in dt.Rows)
            {
                IconButton button = new IconButton();
                button.Text = row[1].ToString();
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
                button.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                button.Size = new Size(100, 30);
                button.Tag = row[0].ToString();
                button.Click += new EventHandler(ChooseMenuProduct);
                lstProducts.Controls.Add(button);
            }
        }
        private void ChooseMenuProduct(object? sender, EventArgs e)
        {
            lvProducts.Visible = true;
            lvProducts.Items.Clear();
            lstProduct.Clear();
            Control? c;
            c = sender as Control;
            string id;
            id = c.Tag.ToString();
            string query = "select * from Product where Classify = '" + id + "'";
            ShowListProduct(query);
        }
        private void ShowListProduct(string name)
        {
            DataTable dt = new DataTable();
            ListViewItem listViewItem;
            dt = data.GetData(name);
            foreach (DataRow row in dt.Rows)
            {
                listViewItem = new ListViewItem(row[1].ToString());
                listViewItem.SubItems.Add(row[2].ToString());
                lvProducts.Items.Add(listViewItem);
            }
        }

        private void lvProducts_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lv1 = lvProducts.SelectedItems[0];
            productOrder.Visible = true;
            ProductsOrderControl pd = new ProductsOrderControl(lv1.SubItems[0].Text, lv1.SubItems[1].Text);
            flpProductOrder.Controls.Add(pd);
        }

        private void cbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDiscount.Text = cbDiscount.SelectedIndex.ToString();
        }

        
    }
}


