using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Testprices
    {
        public int Testcode { get; set; }
        public short Pcategorycode { get; set; }
        public decimal Testprice { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Testpricedel { get; set; }
    }
}
