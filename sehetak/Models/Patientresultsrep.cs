using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientresultsrep
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public int Parametercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Usercode { get; set; }
        public string Parametervalue { get; set; }
        public string Reporteddata { get; set; }
        public string Phcode { get; set; }
        public DateTime? TableDumped { get; set; }
        public byte? Resno { get; set; }
    }
}
