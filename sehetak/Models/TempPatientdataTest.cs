using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class TempPatientdataTest
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public DateTime Patientdate { get; set; }
        public int Dbltestflag { get; set; }
        public string Usercode { get; set; }
    }
}
