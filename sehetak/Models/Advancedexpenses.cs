using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Advancedexpenses
    {
        public string Branchcode { get; set; }
        public int Aesno { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public decimal Aevalue { get; set; }
        public string Suppcode { get; set; }
        public string Costcentercode { get; set; }
        public int ExpcodeAsset { get; set; }
        public int Expcode { get; set; }
        public string Aecomment { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
