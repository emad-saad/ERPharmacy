using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class ChequesCashed
    {
        public int Cheqsno { get; set; }
        public DateTime Cheqcashdate { get; set; }
        public short Cashtype { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public string Cashnote { get; set; }
        public string Bankcode { get; set; }
        public short? RefuseReason { get; set; }
        public decimal? Cheqcashfees { get; set; }
        public string Safecode { get; set; }
        public string Branchcode { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
