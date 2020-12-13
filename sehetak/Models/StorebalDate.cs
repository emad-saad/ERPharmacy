using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class StorebalDate
    {
        public DateTime Storebaldate1 { get; set; }
        public string Storecode { get; set; }
        public string Itemcode { get; set; }
        public decimal Itemsaleprice { get; set; }
        public decimal Itemcostprice { get; set; }
        public decimal Nowqty { get; set; }
        public decimal Nowcostprice { get; set; }
    }
}
