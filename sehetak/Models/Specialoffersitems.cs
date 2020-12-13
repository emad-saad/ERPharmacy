using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Specialoffersitems
    {
        public int Offersno { get; set; }
        public string Itemcode { get; set; }
        public byte Itemtype { get; set; }
        public byte Itemblock { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
