using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientresults
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public int Parametercode { get; set; }
        public string Parametervalue { get; set; }
        public string Minvalue { get; set; }
        public string Maxvalue { get; set; }
        public string Parameterdescr { get; set; }
        public string Usercode { get; set; }
        public string Phcode { get; set; }
        public byte? Resultsource { get; set; }
        public DateTime? TableDumped { get; set; }
        public DateTime? TransTime { get; set; }
        public string Sbranchcode { get; set; }
        public byte? Resno { get; set; }
        public string Minvaluecrit { get; set; }
        public string Maxvaluecrit { get; set; }
        public string Minvaluepos { get; set; }
        public string Maxvaluepos { get; set; }
    }
}
