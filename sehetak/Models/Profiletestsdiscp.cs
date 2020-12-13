using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Profiletestsdiscp
    {
        public int Profilecode { get; set; }
        public int Testcode { get; set; }
        public decimal Testpricediscp { get; set; }
        public short Pcategorycode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string ProfiletestNomoreuse { get; set; }
        public string Testpricetype { get; set; }
    }
}
