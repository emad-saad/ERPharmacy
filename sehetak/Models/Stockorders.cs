using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Stockorders
    {
        public string Branchcode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public string Itemcode { get; set; }
        public decimal ItemqtyCfarma { get; set; }
        public decimal Itemqty { get; set; }
        public decimal Itemqtyget { get; set; }
        public decimal Itemsaleprice { get; set; }
        public decimal Transprice { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public decimal Nowqty { get; set; }
        public decimal Pharmacydiscp { get; set; }
        public decimal Additionaldiscp { get; set; }
        public decimal Specialdiscp { get; set; }
        public decimal Bonusqty { get; set; }
        public decimal Itemsalestax { get; set; }
        public string Suppcode { get; set; }
        public decimal Bonusqtyget { get; set; }
        public short Dblitemflag { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Itemname { get; set; }
    }
}
