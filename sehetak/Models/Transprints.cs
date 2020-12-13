using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Transprints
    {
        public string BranchcodeP { get; set; }
        public short Transtype { get; set; }
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public int Docsno { get; set; }
        public string Mitemname { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
