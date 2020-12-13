using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Samples
    {
        public short Samplecode { get; set; }
        public string Samplename { get; set; }
        public short Sampleunitcode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Samplecolor { get; set; }
    }
}
