using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class TempInv6
    {
        public string Branchcode { get; set; }
        public string Productidno { get; set; }
        public int Transno1 { get; set; }
        public int Transno2 { get; set; }
        public string Luid { get; set; }
        public DateTime Luiddate { get; set; }
        public byte[] Libdata { get; set; }
    }
}
