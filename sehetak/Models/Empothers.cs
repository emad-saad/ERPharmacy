using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empothers
    {
        public string Personcode { get; set; }
        public DateTime Actiondate { get; set; }
        public short Othersclassif { get; set; }
        public decimal Empsalperday { get; set; }
        public decimal Othersmoney { get; set; }
        public string Othersapprovedby { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Otherscomments { get; set; }
    }
}
