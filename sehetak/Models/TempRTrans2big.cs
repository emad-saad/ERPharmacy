using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class TempRTrans2big
    {
        public string Itemcode { get; set; }
        public decimal Itemqty { get; set; }
        public decimal Itemvalue { get; set; }
        public decimal Itemnowqty { get; set; }
        public string BranchCode { get; set; }
        public DateTime? Sdate { get; set; }
        public DateTime? Fdate { get; set; }
        public string Usercode { get; set; }
        public short? Orderitem { get; set; }
    }
}
