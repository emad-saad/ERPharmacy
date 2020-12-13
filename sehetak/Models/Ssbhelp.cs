using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Ssbhelp
    {
        public string Ssbver { get; set; }
        public string Sno { get; set; }
        public byte[] Ssbhelptxt { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
