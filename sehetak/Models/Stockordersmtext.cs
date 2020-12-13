using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Stockordersmtext
    {
        public string Branchcode { get; set; }
        public decimal Docnumber { get; set; }
        public short Ordertextlineno { get; set; }
        public string Ordertext { get; set; }
        public byte Linebold { get; set; }
        public byte Lineunderline { get; set; }
        public byte Linestrikeout { get; set; }
        public string Linefixed { get; set; }
        public short Linefont { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
