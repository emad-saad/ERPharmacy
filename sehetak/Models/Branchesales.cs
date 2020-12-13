using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Branchesales
    {
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public int Paymentsno { get; set; }
        public string Paymenttype { get; set; }
        public decimal Paymentvalue { get; set; }
        public decimal RefDocnumber { get; set; }
        public decimal? LocalpaymentRemain { get; set; }
        public int? LocalpaymentSno { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public string Comment { get; set; }
        public string Personcode { get; set; }
        public int? HourOfDay { get; set; }
        public string Samedayhours { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Intervalcode { get; set; }
        public DateTime? Intervaldocdate { get; set; }
        public DateTime? Cheqdate { get; set; }
        public byte? Creditcardtype { get; set; }
    }
}
