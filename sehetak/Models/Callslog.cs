using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Callslog
    {
        public string Branchcode { get; set; }
        public DateTime TransTime { get; set; }
        public string Resultstring { get; set; }
        public DateTime? Calldate { get; set; }
        public DateTime? Calltime { get; set; }
        public short? Calllineno { get; set; }
        public short? Extno { get; set; }
        public string Otherno { get; set; }
        public int? Callduration { get; set; }
    }
}
