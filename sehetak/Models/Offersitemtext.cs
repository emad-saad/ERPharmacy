using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Offersitemtext
    {
        public string Branchcode { get; set; }
        public decimal Docnumber { get; set; }
        public string Itemcode { get; set; }
        public short Itemtextlineno { get; set; }
        public string Itemtext { get; set; }
        public byte Linebold { get; set; }
        public byte Lineunderline { get; set; }
        public byte Linestrikeout { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
