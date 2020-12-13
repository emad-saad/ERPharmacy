using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class StktransBrrec
    {
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public string Storecode { get; set; }
        public string Itemcode { get; set; }
        public short Dblitemflag { get; set; }
        public decimal TransqtyNrec { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
        public byte Recsno { get; set; }
        public byte Itemrec { get; set; }
    }
}
