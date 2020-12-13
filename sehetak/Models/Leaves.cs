using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Leaves
    {
        public string Leavetype { get; set; }
        public string Leavedescr { get; set; }
        public decimal? Noofdays { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public byte? Hasbal { get; set; }
        public short Applydays { get; set; }
        public string Vf1 { get; set; }
    }
}
