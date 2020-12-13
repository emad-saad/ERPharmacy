using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class R3stktransold
    {
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public string Storecode { get; set; }
        public string Itemcode { get; set; }
        public decimal Transqty { get; set; }
        public decimal Transprice { get; set; }
        public decimal? Newqty { get; set; }
        public decimal? Newcostprice { get; set; }
        public DateTime? Itemexpirydate { get; set; }
        public decimal Itemsaleprice { get; set; }
        public decimal? Itemsalestax { get; set; }
        public decimal? ItemsalepriceTax { get; set; }
        public decimal? Pharmacydiscp { get; set; }
        public decimal? Additionaldiscp { get; set; }
        public decimal TranspriceTotal { get; set; }
        public decimal? Origintaxp { get; set; }
        public decimal? Custdiscp { get; set; }
        public decimal Specialdiscp { get; set; }
        public decimal Bonusqty { get; set; }
        public short Dblitemflag { get; set; }
        public decimal? RDocnumber { get; set; }
        public DateTime? RDocdate { get; set; }
        public decimal? SalepriceExtrap { get; set; }
        public string Suppliercode { get; set; }
        public string RDoccode { get; set; }
        public string SDoccode { get; set; }
        public decimal? SDocnumber { get; set; }
        public DateTime? SDocdate { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public string Personcode { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Storecode2 { get; set; }
        public decimal? Retqty { get; set; }
        public string ItemPartno { get; set; }
        public string Costcentercode { get; set; }
        public decimal? Rcostprice { get; set; }
        public string Vf1 { get; set; }
        public string Vf2 { get; set; }
    }
}
