using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Itemssuppliers
    {
        public string Itemcode { get; set; }
        public string Suppcode { get; set; }
        public string Suppitemcode { get; set; }
        public short Itemsort { get; set; }
        public string MainSupp { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public decimal? Pharmacydiscp { get; set; }
        public decimal? Additionaldiscp { get; set; }
        public decimal? Specialdiscp { get; set; }
        public decimal? Itemsaleprice { get; set; }
        public decimal? Itemcostprice { get; set; }
        public decimal? Itemsalestax { get; set; }
        public decimal? Itemsalestaxp { get; set; }
    }
}
