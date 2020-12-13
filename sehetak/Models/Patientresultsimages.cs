using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientresultsimages
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public short Testcodesno { get; set; }
        public byte[] Itempicture { get; set; }
        public byte Imagetype { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public string Sbranchcode { get; set; }
    }
}
