using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empborrowpayments
    {
        public string Personcode { get; set; }
        public DateTime Borrowdate { get; set; }
        public DateTime Borrowreturndate { get; set; }
        public decimal Borrowpayvalue { get; set; }
        public DateTime? Borrowpaydate { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public string Blockpayment { get; set; }
    }
}
