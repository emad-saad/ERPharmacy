using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class EmpTaxfreeitems
    {
        public string Personcode { get; set; }
        public string Taxfreeitem { get; set; }
        public byte Itemactive { get; set; }
        public decimal Taxfreevalue { get; set; }
        public byte TaxpercentInsur1 { get; set; }
        public byte TaxpercentInsur2 { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
