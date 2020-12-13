using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Piccrmitems
    {
        public string Branchcode { get; set; }
        public string Custphcode { get; set; }
        public decimal Crmorderno { get; set; }
        public short Crmorderflag { get; set; }
        public string Itemcode { get; set; }
        public decimal Itemqty { get; set; }
        public short Itemqtyp { get; set; }
        public short Itemqtyu { get; set; }
        public decimal Itemsaleprice { get; set; }
        public decimal Unitsaleprice { get; set; }
        public decimal Itemsalestaxp { get; set; }
        public decimal Itemsalestax { get; set; }
        public decimal Custdiscp { get; set; }
        public decimal Transprice { get; set; }
        public int? Specialoffersno { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Obranchcode { get; set; }
        public string Sbranchcode { get; set; }
        public decimal Sitemqty { get; set; }
        public short Stime { get; set; }
        public DateTime? TableDumped { get; set; }
        public decimal Nowqty { get; set; }
        public decimal Nowcostprice { get; set; }
        public decimal Itempoints { get; set; }
        public int Docnumber { get; set; }
        public byte Orderstatus { get; set; }
        public DateTime Orderstatustime { get; set; }
        public int? Sdocnumber { get; set; }
    }
}
