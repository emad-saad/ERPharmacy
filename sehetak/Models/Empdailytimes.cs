using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empdailytimes
    {
        public string Personcode { get; set; }
        public byte Dayno { get; set; }
        public string Empstime { get; set; }
        public string Empftime { get; set; }
        public string Empstime1 { get; set; }
        public string Empftime1 { get; set; }
        public string Empstime2 { get; set; }
        public string Empftime2 { get; set; }
        public string Empstime3 { get; set; }
        public string Empftime3 { get; set; }
        public byte Weeklyleave { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public byte Nightshift { get; set; }
        public byte Nightshift2 { get; set; }
        public short Dailytimestd { get; set; }
        public short Dailytimesp { get; set; }
        public byte Apply2 { get; set; }
    }
}
