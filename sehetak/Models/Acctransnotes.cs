using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Acctransnotes
    {
        public string VerBranchL1 { get; set; }
        public decimal Accsno { get; set; }
        public string Accnote { get; set; }
        public string VerBranchL1Orig { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
