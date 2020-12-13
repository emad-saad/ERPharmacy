using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class StktransmBrrec
    {
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public byte Recstatus { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
        public string BrBranchcode { get; set; }
        public string BrDoccode { get; set; }
        public decimal BrDocnumber { get; set; }
        public DateTime BrDocdate { get; set; }
        public string BrStorecode { get; set; }
    }
}
