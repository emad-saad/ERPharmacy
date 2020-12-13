using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class StkbalCheck3
    {
        public string Repbranchcode { get; set; }
        public int Repsno { get; set; }
        public byte Rep3fixed { get; set; }
        public decimal Lastdocnumberout { get; set; }
        public decimal Lastdocnumberin { get; set; }
    }
}
