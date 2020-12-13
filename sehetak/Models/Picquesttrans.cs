using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Picquesttrans
    {
        public string Pic { get; set; }
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Questsno { get; set; }
        public short Questanswer { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
