using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientcomments
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public string Comments { get; set; }
        public int Testcode { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Sbranchcode { get; set; }
        public DateTime? TransTime { get; set; }
        public string Usercode { get; set; }
    }
}
