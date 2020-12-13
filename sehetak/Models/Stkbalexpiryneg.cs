using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Stkbalexpiryneg
    {
        public string Storecode { get; set; }
        public string Itemcode { get; set; }
        public DateTime Itemexpirydate { get; set; }
        public decimal Itemqtyneg { get; set; }
    }
}
