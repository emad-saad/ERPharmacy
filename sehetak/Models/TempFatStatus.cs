using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class TempFatStatus
    {
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal RDocnumber { get; set; }
        public DateTime Docdate { get; set; }
    }
}
