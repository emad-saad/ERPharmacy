﻿using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Offerstext
    {
        public string Branchcode { get; set; }
        public decimal Docnumber { get; set; }
        public short Offertextlineno { get; set; }
        public string Offertext { get; set; }
        public byte Linebold { get; set; }
        public byte Lineunderline { get; set; }
        public byte Linestrikeout { get; set; }
        public string Linefixed { get; set; }
        public short Linefont { get; set; }
    }
}
