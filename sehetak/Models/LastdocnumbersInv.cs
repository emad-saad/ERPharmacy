using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class LastdocnumbersInv
    {
        public string Branchcode { get; set; }
        public decimal Lastdocnumberin { get; set; }
        public decimal Lastdocnumberout { get; set; }
        public decimal LastdocnumberinCust { get; set; }
        public decimal LastdocnumberoutCust { get; set; }
        public decimal LastdocnumberinSupp { get; set; }
        public decimal LastdocnumberoutSupp { get; set; }
    }
}
