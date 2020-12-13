using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Custpayments
    {
        public string Custcode { get; set; }
        public DateTime Custpaydate { get; set; }
        public decimal Custpayvalue { get; set; }
        public decimal Custdeductvalue { get; set; }
        public string Usercode { get; set; }
        public DateTime Userentrydate { get; set; }
    }
}
