using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Testsamples
    {
        public int Testcode { get; set; }
        public short Samplecode { get; set; }
        public decimal Samplesize { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public byte Sampleblock { get; set; }
    }
}
