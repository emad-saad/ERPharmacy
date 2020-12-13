using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class CommunicTselecthd
    {
        public string Branchcode { get; set; }
        public int Tsno { get; set; }
        public DateTime TableDumpedsince { get; set; }
        public DateTime Successdate { get; set; }
        public byte Transresult { get; set; }
        public int Contime { get; set; }
        public int Reccount { get; set; }
        public DateTime TransTime { get; set; }
    }
}
