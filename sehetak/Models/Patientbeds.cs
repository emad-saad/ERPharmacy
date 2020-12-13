using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientbeds
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public string Phcode { get; set; }
        public string Hroombedno { get; set; }
        public short Totbeds { get; set; }
        public byte BedStatus { get; set; }
        public byte Bedpatient { get; set; }
        public byte Bedcompanion { get; set; }
        public byte Bedempty { get; set; }
    }
}
