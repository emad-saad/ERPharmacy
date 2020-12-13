using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Stktransmclassif
    {
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public string Custdiscpcode { get; set; }
        public decimal Docvalue { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
