using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AppBanHang.Models;

namespace AppBanHang.Database
{
    internal class SqlDatabaseUsing
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DYN\SQL;Initial Catalog=WaterShop;Integrated Security=True") ;
        SqlCommand command;
        SqlDataReader reader;
        public DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            connect.Open();
            command = connect.CreateCommand();
            command.CommandText = query;
            reader = command.ExecuteReader();
            dt.Load(reader);
            connect.Close();
            return dt;
        }
        public bool InsertBill(BillModdel bill)
        {
            bool b = false;
            bool b1 = false;
            bool b2 = false;
            connect.Open();
            string queryBill = "insert into Bill(ID, CustomerCode, TableOrder, Date, IntoMoney, Status, Formality, Total) values (@ID, @CustomerCode, @TableOrder, @Date, @IntoMoney, @Status, @Formality, @Total) ";
            SqlCommand cmdBill = new SqlCommand(queryBill,connect);
            cmdBill.Parameters.AddWithValue("id", bill.Id);
            cmdBill.Parameters.AddWithValue("CustomerCode", bill.CustomerCode);
            cmdBill.Parameters.AddWithValue("TableOrder", bill.TableOrder);
            cmdBill.Parameters.AddWithValue("Date", bill.Date);
            cmdBill.Parameters.AddWithValue("IntoMoney", bill.IntoMoney);
            cmdBill.Parameters.AddWithValue("Status", bill.Status);
            cmdBill.Parameters.AddWithValue("Formality", bill.Formality);
            cmdBill.Parameters.AddWithValue("Total", bill.Total);
            int k = cmdBill.ExecuteNonQuery();
            if (k >0)
                b1 = true;
            List<ListOrder> list = bill.listOrder;
            foreach(ListOrder order in list)
            {
                b2 = false;
                string queryListOrder = "insert into ListOrder(Name, Size, Price, Quality, Total, IdBill) values (@Name, @Size, @Price, @Quality, @Total, @IdBill)";
                SqlCommand cmdListOrder = new SqlCommand(queryListOrder,connect);
                cmdListOrder.Parameters.AddWithValue("Name", order.Name);
                cmdListOrder.Parameters.AddWithValue("Size", order.Size);
                cmdListOrder.Parameters.AddWithValue("Price", order.Price);
                cmdListOrder.Parameters.AddWithValue("Quality", order.Quality);
                cmdListOrder.Parameters.AddWithValue("Total", order.Total);
                cmdListOrder.Parameters.AddWithValue("IdBill", order.IdOrder);
                int h = cmdListOrder.ExecuteNonQuery();
                if (h>0)
                {
                    b2 = true;
                }
            }
            if(b1==true && b2==true)
                b = true;
            connect.Close();
            return b;
        }
    }
}
