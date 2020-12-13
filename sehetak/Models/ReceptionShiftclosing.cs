using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class ReceptionShiftclosing
    {
        public string Branchcode { get; set; }
        public string Cashiercode { get; set; }
        public string Financialdoccode { get; set; }
        public DateTime TransTime { get; set; }
        public decimal UserCashinhand { get; set; }
        public decimal Moneyvalue1 { get; set; }
        public decimal MoneyvalueGet { get; set; }
        public string Usercode { get; set; }
        public decimal UserCashinhand2 { get; set; }
        public decimal OtherCashinhand { get; set; }
        public string OtherCashiercode { get; set; }
        public int UptoPcode { get; set; }
        public int UptoIsno { get; set; }
        public DateTime? TableDumped { get; set; }
        public int UptoRsno { get; set; }
    }
}
