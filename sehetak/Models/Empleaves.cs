using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empleaves
    {
        public string Personcode { get; set; }
        public DateTime Leavesdate { get; set; }
        public DateTime Leavefdate { get; set; }
        public string Leavetype { get; set; }
        public string Leavenote { get; set; }
        public string Leavesource { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public int Leavedays { get; set; }
        public byte? Shiftleave { get; set; }
        public string Slstime { get; set; }
        public string Slftime { get; set; }
    }
}
