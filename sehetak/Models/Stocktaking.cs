using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Stocktaking
    {
        public string Branchcode { get; set; }
        public DateTime Stockdate { get; set; }
        public string Itemcode { get; set; }
        public decimal Itemqty { get; set; }
        public DateTime? Itemexpirydate { get; set; }
        public string Usercode { get; set; }
        public float StocktakeSno { get; set; }
        public short Itemexpiry { get; set; }
        public short StocktakeFinal { get; set; }
        public decimal Nowqty { get; set; }
        public decimal Nowcostprice { get; set; }
        public decimal Itemsaleprice { get; set; }
        public DateTime? TransTime { get; set; }
        public byte OpenBal { get; set; }
        public string Batchno { get; set; }
    }
}
