using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class CustOrders
    {
        public int Orderid { get; set; }
        public string Customerpic { get; set; }
        public DateTime Orderdate { get; set; }
        public DateTime Orderdownloaddate { get; set; }
        public byte Orderdone { get; set; }
        public string Itemcode { get; set; }
        public decimal Itemprice { get; set; }
        public decimal Itemquantity { get; set; }
    }
}
