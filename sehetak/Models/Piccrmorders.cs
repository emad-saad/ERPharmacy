using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Piccrmorders
    {
        public string Crmbranchcode { get; set; }
        public int Crmorderno { get; set; }
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber5 { get; set; }
        public DateTime Docdate5 { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Orderdatetime { get; set; }
        public string Orderusercode { get; set; }
        public decimal Ordervalue { get; set; }
        public DateTime? Execorderdatetime { get; set; }
        public string Execorderusercode { get; set; }
        public string Drivercode { get; set; }
        public DateTime? Driveroutdatetime { get; set; }
        public decimal Driveroutvalue { get; set; }
        public DateTime? Driverindatetime { get; set; }
        public int Drivertime { get; set; }
        public string Phcode { get; set; }
        public DateTime? Orderdatetimes { get; set; }
        public DateTime? Ordertobr { get; set; }
        public DateTime? Ordertobrtaken { get; set; }
        public DateTime? Orderinvoice { get; set; }
        public DateTime? Delivertocust { get; set; }
        public short? Orderstatus { get; set; }
        public DateTime? Orderstatustime { get; set; }
    }
}
