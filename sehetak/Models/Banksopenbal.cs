using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Banksopenbal
    {
        public string Bankcode { get; set; }
        public decimal Bankopendebit { get; set; }
        public decimal Bankopencredit { get; set; }
        public DateTime Bankopendate { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public decimal BankopendebitLc { get; set; }
        public decimal BankopencreditLc { get; set; }
        public byte Bcurrency { get; set; }
        public decimal Bcrate { get; set; }
        public string Opentrans { get; set; }
    }
}
