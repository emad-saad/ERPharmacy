using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class PosShiftclosing
    {
        public string Branchcode { get; set; }
        public string Cashiercode { get; set; }
        public string Paymenttype { get; set; }
        public DateTime TransTime { get; set; }
        public decimal Moneyvalue1 { get; set; }
        public decimal Moneyvalue2 { get; set; }
        public string Usercode { get; set; }
        public decimal UptoSalesdocnumber { get; set; }
        public decimal UserCashinhand { get; set; }
        public decimal UserCashinhand2 { get; set; }
        public decimal OtherCashinhand { get; set; }
        public string OtherCashiercode { get; set; }
        public decimal UserMoneyvalue3 { get; set; }
        public decimal UserMoneyvalue4 { get; set; }
        public decimal UserMoneyvalue5 { get; set; }
        public decimal UptoCheqsno { get; set; }
        public decimal Moneyvalue1Get { get; set; }
        public DateTime? TableDumped { get; set; }
        public decimal Moneyvaluesales { get; set; }
        public decimal Moneyvalueret { get; set; }
    }
}
