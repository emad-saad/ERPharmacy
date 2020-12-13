using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Stockordersmpay
    {
        public string Branchcode { get; set; }
        public decimal Docnumber { get; set; }
        public short Paylineno { get; set; }
        public decimal Payvalue { get; set; }
        public string Financialdoccode { get; set; }
        public DateTime Paydate { get; set; }
        public string Paycomment { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
