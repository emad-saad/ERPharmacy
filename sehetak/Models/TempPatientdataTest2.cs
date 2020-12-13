using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class TempPatientdataTest2
    {
        public string Usercode { get; set; }
        public int Usersno { get; set; }
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public DateTime? Patientdate { get; set; }
        public DateTime? Patienttime { get; set; }
        public int Testcode { get; set; }
        public string Testname { get; set; }
        public int? Paramcode { get; set; }
        public string Paramname { get; set; }
        public string Paramvalue { get; set; }
    }
}
