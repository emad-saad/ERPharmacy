using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Mi3Patientdata
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public string Patientname { get; set; }
        public DateTime Patientdobirth { get; set; }
        public string Patientsex { get; set; }
    }
}
