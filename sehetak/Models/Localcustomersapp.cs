using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Localcustomersapp
    {
        public string Phcode { get; set; }
        public int Sappsno { get; set; }
        public DateTime Sappdate { get; set; }
        public byte Testtype { get; set; }
        public string Itemtestcode { get; set; }
        public string Itemtestdescr { get; set; }
        public decimal Itemqty { get; set; }
        public decimal Itemtestprice { get; set; }
        public string Sappcomments { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public byte Sappblocked { get; set; }
    }
}
