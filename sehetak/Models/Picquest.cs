using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Picquest
    {
        public int Questsno { get; set; }
        public string Questdescr { get; set; }
        public string Questedescr { get; set; }
        public int Questorder { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public byte Questblock { get; set; }
        public string Blockuser { get; set; }
        public DateTime? Blocktranstime { get; set; }
    }
}
