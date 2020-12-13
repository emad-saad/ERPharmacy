using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Mi3Patienttests
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public DateTime Testsampledate { get; set; }
    }
}
