using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Tripspricesref
    {
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public byte Priceref { get; set; }
        public byte Pricerefblock { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public string Usercode { get; set; }
    }
}
