using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Bankcurrenciestrans
    {
        public byte Bcurrency { get; set; }
        public decimal Bcrate { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public decimal BcrateMaxpay { get; set; }
        public decimal BcrateMinreceive { get; set; }
    }
}
