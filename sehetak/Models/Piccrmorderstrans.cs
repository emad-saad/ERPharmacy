using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Piccrmorderstrans
    {
        public string Branchcode { get; set; }
        public decimal Docnumber5 { get; set; }
        public byte Transdir { get; set; }
        public string Drivercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
