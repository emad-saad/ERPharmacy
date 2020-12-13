using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Banks
    {
        public string Bankcode { get; set; }
        public string Bankname { get; set; }
        public string Bankaccountno { get; set; }
        public decimal Bankaccountbalance { get; set; }
        public short Banktype { get; set; }
        public string Acciteml6 { get; set; }
        public string Branchcode { get; set; }
        public byte? Bcurrency { get; set; }
        public decimal? BankaccountbalanceLc { get; set; }
        public string Accitemcode { get; set; }
        public string Accitemcode2 { get; set; }
        public string Accitemcode3 { get; set; }
        public string Accitemcode4 { get; set; }
        public string Accitemcode5 { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Bankprint { get; set; }
    }
}
