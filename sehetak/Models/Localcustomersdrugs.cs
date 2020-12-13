using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Localcustomersdrugs
    {
        public string Phcode { get; set; }
        public string Itemcode { get; set; }
        public decimal Itemqty { get; set; }
        public byte Itemblock { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
