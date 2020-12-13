using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Modelspecs
    {
        public string Modelcode { get; set; }
        public int Modelyear { get; set; }
        public string Modelcountry { get; set; }
        public string Enginetype { get; set; }
        public string Enginepower { get; set; }
        public int? Noofseats { get; set; }
        public string Gearboxtype { get; set; }
        public string Batterycode { get; set; }
        public int? Noofbatteries { get; set; }
        public string Tirecode { get; set; }
        public int? Nooftires { get; set; }
        public int? Fueltankmain { get; set; }
        public int? Fueltankspare { get; set; }
        public int? Oiltankcapacity { get; set; }
        public short? Fridgetype { get; set; }
        public int? Fridgecapacity { get; set; }
        public short? Toilet { get; set; }
        public int? Curtains { get; set; }
        public short? Cassette { get; set; }
        public short? Amplifier { get; set; }
        public short? Microphone { get; set; }
        public short? Vcr { get; set; }
        public short? Tv { get; set; }
        public short? Abs { get; set; }
        public short? Telema { get; set; }
        public short? Turbo { get; set; }
        public string Ac { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
