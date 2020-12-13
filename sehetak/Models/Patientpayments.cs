using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientpayments
    {
        public string Branchcode { get; set; }
        public int Isalserialno { get; set; }
        public int Patientcode { get; set; }
        public DateTime Paymentdate { get; set; }
        public decimal Paymentvalue { get; set; }
        public decimal? Whopaidthis { get; set; }
        public string Usercode { get; set; }
        public DateTime? TableDumped { get; set; }
        public byte? Patientdeleted { get; set; }
        public string Financialdoccode { get; set; }
        public byte? Creditcardtype { get; set; }
        public string Comment { get; set; }
        public DateTime? Cheqdate { get; set; }
        public int? Noofprints { get; set; }
        public byte Paytype { get; set; }
    }
}
