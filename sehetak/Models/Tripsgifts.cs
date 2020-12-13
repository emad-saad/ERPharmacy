using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Tripsgifts
    {
        public short Tripcode { get; set; }
        public string Carcapacitycode { get; set; }
        public decimal Tripgift { get; set; }
        public decimal Tripgift2 { get; set; }
        public short Pcategorycode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
