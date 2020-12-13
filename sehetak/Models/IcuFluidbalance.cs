using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class IcuFluidbalance
    {
        public string Pic { get; set; }
        public DateTime Transdate { get; set; }
        public DateTime Transtime { get; set; }
        public int Fluidcode { get; set; }
        public int Fluidqty { get; set; }
    }
}
