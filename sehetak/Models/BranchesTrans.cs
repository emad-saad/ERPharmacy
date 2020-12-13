using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class BranchesTrans
    {
        public string Usercode { get; set; }
        public string Branchcode { get; set; }
        public decimal BuyFromMain { get; set; }
        public decimal ReturnToMain { get; set; }
        public decimal SalesCredit { get; set; }
        public decimal CashToMain { get; set; }
    }
}
