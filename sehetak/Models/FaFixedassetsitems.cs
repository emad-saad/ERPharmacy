using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class FaFixedassetsitems
    {
        public string BuyBranchcode { get; set; }
        public decimal BuyDocnumber { get; set; }
        public int Bsno { get; set; }
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public string Itemcode { get; set; }
        public decimal Transqty { get; set; }
        public decimal Transprice { get; set; }
        public short Dblitemflag { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public int? Expcode { get; set; }
        public string Costcentercode { get; set; }
    }
}
