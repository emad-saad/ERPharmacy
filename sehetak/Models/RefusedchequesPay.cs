using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class RefusedchequesPay
    {
        public int Cheqsno { get; set; }
        public DateTime Paydate { get; set; }
        public decimal Payamount { get; set; }
        public short Paytype { get; set; }
        public string Paycomment { get; set; }
        public string Branchcode { get; set; }
    }
}
