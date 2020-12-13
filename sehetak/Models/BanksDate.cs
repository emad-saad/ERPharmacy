using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class BanksDate
    {
        public DateTime Refdate { get; set; }
        public string Bankcode { get; set; }
        public decimal Bankaccountbalance { get; set; }
        public decimal BankaccountbalanceLc { get; set; }
    }
}
