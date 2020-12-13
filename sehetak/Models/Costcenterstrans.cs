using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Costcenterstrans
    {
        public int Ccsno { get; set; }
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public int Cheqsno { get; set; }
        public byte TransSource { get; set; }
        public string Costcentercode { get; set; }
        public decimal Costvalue { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public decimal TransSign { get; set; }
        public int Expcode { get; set; }
        public DateTime? TableDumped { get; set; }
        public string VerBranchcode { get; set; }
        public string Recdata { get; set; }
    }
}
