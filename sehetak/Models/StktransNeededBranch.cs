using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class StktransNeededBranch
    {
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public string Itemcode { get; set; }
    }
}
