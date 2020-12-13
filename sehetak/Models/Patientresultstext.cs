using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientresultstext
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public int Parametercode { get; set; }
        public string Parametertext { get; set; }
        public string Usercode { get; set; }
        public DateTime? TableDumped { get; set; }
        public DateTime? TransTime { get; set; }
        public string Sbranchcode { get; set; }
    }
}
