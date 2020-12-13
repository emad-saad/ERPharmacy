using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Bankcurrencies
    {
        public byte Bcurrency { get; set; }
        public string Bcurrencydescr { get; set; }
        public decimal Bcrate { get; set; }
        public decimal BcrateMaxpay { get; set; }
        public decimal BcrateMinreceive { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Bankcurrencytafkit { get; set; }
        public string Bankcurrencytafkit2 { get; set; }
        public string Bankcurrencytafkite { get; set; }
        public string Bankcurrencytafkit2e { get; set; }
    }
}
