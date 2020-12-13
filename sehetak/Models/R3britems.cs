using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class R3britems
    {
        public string Branchcode { get; set; }
        public string Itemcode { get; set; }
        public DateTime TransTime { get; set; }
        public decimal Itemsaleprice { get; set; }
        public decimal Itemsalestax { get; set; }
        public decimal Itemsalestaxp { get; set; }
        public decimal ItemsalepriceTax { get; set; }
        public decimal Pharmacydiscp { get; set; }
        public decimal Additionaldiscp { get; set; }
        public decimal Specialdiscp { get; set; }
        public decimal Itemcostprice { get; set; }
        public string Unitcode { get; set; }
        public short Packqty { get; set; }
        public decimal Unitsaleprice { get; set; }
    }
}
