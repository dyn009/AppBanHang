using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI;
using AppBanHang.Database;
using AppBanHang.Views.Controls.Statisticals;

namespace AppBanHang.Views.Controls
{
    public partial class StatisticalsControl : UserControl
    {
        string srt = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Máy tính\All\C#\Project\AppBanHang\AppBanHang\Database1.mdf;Integrated Security = True";
        SqlDatabaseUsing data = new SqlDatabaseUsing();
        DateTime dateTime = DateTime.Now;
        string day;
        string month;
        string year;
        public StatisticalsControl()
        {
            InitializeComponent();

            cbBillsQuality.SelectedIndex = 0;
            cbBestSeller.SelectedIndex = 0;
            day = dateTime.ToString("ddMMyyyy");
            month = dateTime.ToString("MMyyyy");
            year = dateTime.ToString("yyyy");
            ShowBillQuality("select * from Bill where ID like '%" + day + "%' ");

            ShowBarChart();
        }
        private void cbBillsQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBillChange();
        }
        private void cbBestSeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBestSellerChange();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        
        string str = "";
        private void ShowBarChart()
        {
            DataTable dt = data.GetData("select * from Bill");
            var groupBill = dt.AsEnumerable()
                .GroupBy(row => row["ID"].ToString().Substring(0,8))
                .Select(g => new
                {
                    Day = g.Key,
                    Total = g.Sum(row => Convert.ToInt32(row["IntoMoney"]))
                });


            DataTable dt3 = new DataTable();
            dt3.Columns.Add("Day");
            dt3.Columns.Add("Total");
            int i = 1;
            foreach (var row in groupBill)
            {

                
                dt3.Rows.Add(i,row.Total);

                i++;
            }
            foreach (DataRow row in dt3.Rows)
            {
                str += row[0] + "\t" + row[1] + "\t";
                charRevenue.Series["Total"].Points.AddXY(Convert.ToInt32(row[0]), row[1]);
                
            }
            dataGridView1.DataSource = dt3;
        }
        private void buttonControl1_Click(object sender, EventArgs e)
        {
            
            
            MessageBox.Show(str);
        }
        private void ShowBillChange()
        {
            switch (cbBillsQuality.SelectedIndex)
            {
                case 1:
                    MessageBox.Show("1");
                    ShowBillQuality("select * from Bill where ID like '%" + month + "%' ");
                    break;
                case 2:
                    ShowBillQuality("select * from Bill where ID like '%" + year + "%' ");
                    break;
                default:
                    ShowBillQuality("select * from Bill where ID like '%" + day + "%' ");
                    break;
            }
        }
        private void ShowBestSellerChange()
        {
            switch (cbBestSeller.SelectedIndex)
            {
                case 1:
                    ShowBestSeller("select * from ListOrder where IdBill like '%" + year + "%' ");
                    break;
                default:
                    ShowBestSeller("select * from ListOrder where IdBill like '%" + month + "%' ");
                    break;
            }
        }
        private void ShowBillQuality(string str)
        {
            flpBillQuality.Controls.Clear();
            DataTable dt = data.GetData(str);
            BillQuality billQuality;
            foreach (DataRow row in dt.Rows)
            {
                billQuality = new BillQuality(row[0].ToString(), row[3].ToString(), row[4].ToString());
                flpBillQuality.Controls.Add(billQuality);
            }

        }
        private void ShowBestSeller(string str)
        {
            dgvBestSeller.Controls.Clear();
            DataTable dt = data.GetData(str);

            var groupData = dt.AsEnumerable()
                .GroupBy(row => row["Name"])
                .Select(group => new
                {
                    Name = group.Key,
                    Quality = group.Sum(row => Convert.ToInt32(row["Quality"])),
                    Total = group.Sum(row => Convert.ToInt32(row["Total"]))
                })
                .OrderByDescending(x => x.Total);
            int i = 1;
            foreach (var item in groupData)
            {
                dgvBestSeller.Rows.Add("0" + i.ToString(), item.Name.ToString(), item.Quality.ToString(), item.Total.ToString());
                i++;
                if (i >= 10)
                {
                    dgvBestSeller.Rows.Add(i.ToString(), item.Name.ToString(), item.Quality.ToString(), item.Total.ToString());
                    break;
                }
            }
        }

        
    }
}