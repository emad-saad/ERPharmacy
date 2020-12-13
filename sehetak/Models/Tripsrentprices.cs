using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Tripsrentprices
    {
        public short Tripcode { get; set; }
        public string Carcapacitycode { get; set; }
        public decimal Carrentprice { get; set; }
        public short Pcategorycode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
