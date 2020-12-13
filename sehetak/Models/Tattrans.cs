using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Tattrans
    {
        public string Branchcode { get; set; }
        public short Tatpos { get; set; }
        public string Tatobject { get; set; }
        public DateTime TransTime { get; set; }
        public string Usercode { get; set; }
        public byte Tatobjecttype { get; set; }
        public string Jobranchcode { get; set; }
        public int Jopatientcode { get; set; }
        public short? Samplecode { get; set; }
        public short? Testcode { get; set; }
        public int Tattime { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
