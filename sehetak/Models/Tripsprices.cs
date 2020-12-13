using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Tripsprices
    {
        public short Tripcode { get; set; }
        public short Pcategorycode { get; set; }
        public string Carcapacitycode { get; set; }
        public byte Bcurrency { get; set; }
        public decimal Tripprice { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public decimal Tripspecialprice { get; set; }
    }
}
