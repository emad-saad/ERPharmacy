using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Testpricestrans
    {
        public int Testcode { get; set; }
        public short Pcategorycode { get; set; }
        public DateTime TransTime { get; set; }
        public decimal Testprice { get; set; }
        public string Usercode { get; set; }
        public string Testpricedel { get; set; }
    }
}
