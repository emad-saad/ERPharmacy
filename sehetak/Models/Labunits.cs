using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Labunits
    {
        public short Labunitcode { get; set; }
        public string Labunitname { get; set; }
        public DateTime? Labunitstime { get; set; }
        public DateTime? Labunitftime { get; set; }
        public short? Labunitspan { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public byte Testtype { get; set; }
        public short Reservunit { get; set; }
        public string Unitsymbol { get; set; }
        public int Unitsno { get; set; }
        public byte Emetgency { get; set; }
        public byte? Mainunit { get; set; }
        public byte? Performunit { get; set; }
    }
}
