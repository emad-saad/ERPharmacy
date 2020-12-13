using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Picpoints
    {
        public string Phcode { get; set; }
        public DateTime Transdate { get; set; }
        public int Points { get; set; }
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Vf1 { get; set; }
        public string Vf2 { get; set; }
        public string Vf3 { get; set; }
    }
}
