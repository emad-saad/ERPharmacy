using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Custdiscounts
    {
        public string Personcode { get; set; }
        public string Custdiscpcode { get; set; }
        public decimal Custdiscp { get; set; }
        public short AllowSell { get; set; }
        public DateTime? CustLastupdate { get; set; }
        public decimal Custdiscp2 { get; set; }
        public decimal Custdiscp3 { get; set; }
        public decimal Custdiscp4 { get; set; }
        public string Custdiscptype { get; set; }
        public string CustdiscpNomore { get; set; }
    }
}
