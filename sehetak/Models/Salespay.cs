using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Salespay
    {
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public decimal MoneyRequired { get; set; }
        public decimal MoneyPaid { get; set; }
    }
}
