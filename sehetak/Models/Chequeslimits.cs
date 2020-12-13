using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Chequeslimits
    {
        public short Cheqyear { get; set; }
        public short Cheqmonth { get; set; }
        public decimal Cheqlimit { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public string Usercode { get; set; }
    }
}
