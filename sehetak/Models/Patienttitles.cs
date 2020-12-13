using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patienttitles
    {
        public short Ptitle { get; set; }
        public string Ptitledescr { get; set; }
        public short Ptitleorder { get; set; }
        public string Sex { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Petitledescr { get; set; }
    }
}
