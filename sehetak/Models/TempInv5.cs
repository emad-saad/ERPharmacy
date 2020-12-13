using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class TempInv5
    {
        public string Branchcode { get; set; }
        public string Productidno { get; set; }
        public int Transno { get; set; }
        public decimal? Transvalue { get; set; }
        public byte[] Libdata { get; set; }
    }
}
