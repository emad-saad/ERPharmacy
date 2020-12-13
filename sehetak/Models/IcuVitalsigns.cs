using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class IcuVitalsigns
    {
        public string Pic { get; set; }
        public DateTime Transdate { get; set; }
        public DateTime Transtime { get; set; }
        public int? Heartrate { get; set; }
        public int? Bldpresslow { get; set; }
        public int? Bldpresshigh { get; set; }
        public decimal? Tempr { get; set; }
        public int? Resprate { get; set; }
        public short? Cvptype { get; set; }
        public decimal? Cvp { get; set; }
        public string Bed { get; set; }
        public int? Consultantcode { get; set; }
    }
}
