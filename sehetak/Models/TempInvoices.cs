using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class TempInvoices
    {
        public string Usercode { get; set; }
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public decimal Val1 { get; set; }
        public decimal Val2 { get; set; }
        public decimal Val3 { get; set; }
    }
}
