using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Samplestrans
    {
        public string Frombranch { get; set; }
        public byte Transtype { get; set; }
        public byte Transdir { get; set; }
        public int Frombranchsno { get; set; }
        public short Linesno { get; set; }
        public string Samplebarcode { get; set; }
        public string Tobranch { get; set; }
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Samplecode { get; set; }
        public byte Itemflag1 { get; set; }
        public byte Itemflag2 { get; set; }
        public string Personcode { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
