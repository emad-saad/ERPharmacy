using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientteststime
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public DateTime Teststarttime { get; set; }
        public DateTime? Testfinishtime { get; set; }
        public string Usercode { get; set; }
        public string Machinename { get; set; }
        public string Ptcomeback { get; set; }
    }
}
