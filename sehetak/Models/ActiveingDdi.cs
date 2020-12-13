using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class ActiveingDdi
    {
        public int Aicode { get; set; }
        public int Aicode2 { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Usercode { get; set; }
        public string DdiDescr { get; set; }
        public byte? DdiAction { get; set; }
        public byte? DdiSeverity { get; set; }
        public byte? DdiEvidence { get; set; }
    }
}
