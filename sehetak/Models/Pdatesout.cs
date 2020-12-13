using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Pdatesout
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public DateTime Patientdate { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
