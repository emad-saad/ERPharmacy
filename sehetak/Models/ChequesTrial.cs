using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class ChequesTrial
    {
        public int Cheqsno { get; set; }
        public string Financialdoccode { get; set; }
        public string Cheqtype { get; set; }
        public string Cheqno { get; set; }
        public DateTime Cheqdate { get; set; }
        public string Bankcode { get; set; }
        public string Personcode { get; set; }
        public decimal Cheqvalue { get; set; }
        public short? Cashtype { get; set; }
        public DateTime? Cheqcashdate { get; set; }
        public DateTime Cheqregisterdate { get; set; }
        public DateTime? Cheqtobankdate { get; set; }
        public int? Ourcheqsno { get; set; }
        public string Usercode { get; set; }
        public string Chequenote { get; set; }
        public string WenttoBankstrans { get; set; }
        public string Bankcode2 { get; set; }
        public short? RefuseReason { get; set; }
        public decimal? RefuseCharges { get; set; }
        public decimal? Cheqvaluediscount { get; set; }
        public decimal? Cheqvaluetax { get; set; }
        public decimal? Cheqvaluedamgha { get; set; }
        public DateTime? TransTime { get; set; }
        public string Branchcode { get; set; }
        public int? Payrefusesno { get; set; }
        public string Phcode { get; set; }
    }
}
