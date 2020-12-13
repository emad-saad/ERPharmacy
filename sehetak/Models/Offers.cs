using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Offers
    {
        public string Branchcode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public string Itemcode { get; set; }
        public decimal Itemqty { get; set; }
        public decimal Itemsaleprice { get; set; }
        public decimal Itemsalestaxp { get; set; }
        public decimal Itemsalestax { get; set; }
        public decimal Custdiscp { get; set; }
        public decimal Transprice { get; set; }
        public short? Offerlineno { get; set; }
    }
}
