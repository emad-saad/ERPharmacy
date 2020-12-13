using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Acctrans3
    {
        public decimal Accsno { get; set; }
        public short Acclineno { get; set; }
        public string Accitemcode { get; set; }
        public decimal Acctransdebit { get; set; }
        public decimal Acctranscredit { get; set; }
        public decimal Acctransdebit2 { get; set; }
        public decimal Acctranscredit2 { get; set; }
        public DateTime Acctransdate { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public short Whogeneratedit { get; set; }
        public short Acctranssource { get; set; }
        public decimal? RefNumber { get; set; }
        public short? Acctransyear { get; set; }
        public byte? Acctransmonth { get; set; }
        public byte? Acctransopen { get; set; }
        public DateTime? TableDumped { get; set; }
        public string VerBranchL1 { get; set; }
        public string VerBranchL1Orig { get; set; }
        public string Costcentercode { get; set; }
    }
}
