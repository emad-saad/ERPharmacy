using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientdatadiagnosis
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int DisId { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Diagnosiscomments { get; set; }
    }
}
