using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Unitreportsign
    {
        public int Unitcode { get; set; }
        public string Unitsignl1 { get; set; }
        public string Unitsignl2 { get; set; }
        public string Unitsignl3 { get; set; }
        public string Unitsignr1 { get; set; }
        public string Unitsignr2 { get; set; }
        public string Unitsignr3 { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
    }
}
