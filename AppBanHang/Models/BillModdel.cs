using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanHang.Models
{
    internal class BillModdel
    {
        public string Id { get; set; }
        public List<ListOrder> listOrder { get; set; }
        public string CustomerCode { get; set; }
        public int TableOrder { get; set; }
        public string Date { get; set; }
        public int IntoMoney { get; set; }
        public string Status { get; set; }
        public string Formality { get; set; }
        public float Total { get; set; }
        
        public BillModdel() { }

        public BillModdel(string id, List<ListOrder> listOrder, string customerCode, int tableOrder, string date, int intoMoney, string status, string formality, float total)
        {
            Id = id;
            this.listOrder = listOrder;
            CustomerCode = customerCode;
            TableOrder = tableOrder;
            Date = date;
            IntoMoney = intoMoney;
            Status = status;
            Formality = formality;
            Total = total;
        }
    }
    internal class ListOrder
    {
        public string IdOrder { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
        public int Quality { get; set; }
        public float Total { get; set; }
    }
}
