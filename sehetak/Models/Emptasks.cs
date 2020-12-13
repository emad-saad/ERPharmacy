using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Emptasks
    {
        public int Emptasksno { get; set; }
        public DateTime Emptaskdate { get; set; }
        public string Empcode { get; set; }
        public DateTime? Emptaskstime { get; set; }
        public DateTime? Emptaskftime { get; set; }
        public string Emptaskby { get; set; }
        public string Emptaskdescr { get; set; }
        public string Emptaskclassif { get; set; }
        public byte Emptaskpriority { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public byte Emptaskdone { get; set; }
        public string TaskdoneUsercode { get; set; }
        public DateTime? TaskdoneTransTime { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Branchcode { get; set; }
    }
}
