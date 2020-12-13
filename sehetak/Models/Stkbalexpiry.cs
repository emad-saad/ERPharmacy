using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Stkbalexpiry
    {
        public string Storecode { get; set; }
        public string Itemcode { get; set; }
        public DateTime Itemexpirydate { get; set; }
        public decimal Itemqty { get; set; }
        public string Branchcode { get; set; }
        public string Suppliercode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public string Batchno { get; set; }
    }
}
