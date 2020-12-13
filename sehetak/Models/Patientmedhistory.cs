using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientmedhistory
    {
        public string Branchcode { get; set; }
        public string Phcode { get; set; }
        public short? Bloodgroup { get; set; }
        public string Diagnosis { get; set; }
        public string Olddiseases { get; set; }
        public string Oldmedication { get; set; }
        public string Medhistorycomment { get; set; }
        public string Usercode { get; set; }
    }
}
