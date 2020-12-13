using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Itemscurrencycosts
    {
        public string Itemcode { get; set; }
        public string Suppcode { get; set; }
        public byte Bcurrency { get; set; }
        public decimal Itemcurrcostprice { get; set; }
    }
}
