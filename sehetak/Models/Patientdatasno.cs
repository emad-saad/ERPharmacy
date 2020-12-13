using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientdatasno
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public string Genbranchcode { get; set; }
        public int Labunitcode { get; set; }
        public string Hpcode { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
