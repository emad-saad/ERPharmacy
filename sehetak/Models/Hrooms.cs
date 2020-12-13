using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Hrooms
    {
        public int Hfloor { get; set; }
        public string Hroom { get; set; }
        public int Hroomno { get; set; }
        public int? Hroomstatus { get; set; }
        public string RoomIcu { get; set; }
        public string RoomOperations { get; set; }
        public string HroomExists { get; set; }
        public byte Noofbeds { get; set; }
        public byte Noofbedsocc { get; set; }
        public string Meddept { get; set; }
        public int? Testcode1 { get; set; }
        public int? Testcode2 { get; set; }
    }
}
