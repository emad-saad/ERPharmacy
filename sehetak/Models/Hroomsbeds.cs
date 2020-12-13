using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Hroomsbeds
    {
        public string Hroom { get; set; }
        public string Hroombed { get; set; }
        public byte Hroombedstatus { get; set; }
        public string Phcode { get; set; }
        public byte Bedpatient { get; set; }
        public byte Bedcompanion { get; set; }
        public byte Bedempty { get; set; }
    }
}
