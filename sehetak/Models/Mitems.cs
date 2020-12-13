using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Mitems
    {
        public string Mitemname { get; set; }
        public string Mitemdescr { get; set; }
        public int Mitemorder { get; set; }
        public string Mitemallow { get; set; }
        public string Mitemsys { get; set; }
        public string Mitemsubsys { get; set; }
        public string Mitemedescr { get; set; }
        public string Mitemsubsys2 { get; set; }
        public string Mitemesubsys2 { get; set; }
        public byte Mitemflag1 { get; set; }
        public byte Mitemflag2 { get; set; }
    }
}
