using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Resultsrevising
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public string ReviseBranchcode { get; set; }
        public string ReviseDoctorcode { get; set; }
        public DateTime ReviseTransTime { get; set; }
        public DateTime? TableDumped { get; set; }
        public byte Revno { get; set; }
    }
}
