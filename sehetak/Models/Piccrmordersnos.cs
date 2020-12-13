using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Piccrmordersnos
    {
        public string Crmbranchcode { get; set; }
        public int Crmorderno { get; set; }
        public string Branchcode { get; set; }
        public byte Snoflag { get; set; }
        public int Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime TransTime { get; set; }
    }
}
