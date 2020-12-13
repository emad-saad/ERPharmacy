using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Stockordersrec
    {
        public string Branchcode { get; set; }
        public decimal Docnumber { get; set; }
        public string Itemcode { get; set; }
        public short Itemsno { get; set; }
        public DateTime? Itemexpirydate { get; set; }
        public string Storecode { get; set; }
        public decimal Itemqtyrec { get; set; }
        public decimal Bonusqtyrec { get; set; }
        public string Refbranchcode { get; set; }
        public decimal Refdocnumber { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public int Purchaseno { get; set; }
        public short Dblitemflag { get; set; }
        public byte? Newitem { get; set; }
        public string Batchno { get; set; }
    }
}
