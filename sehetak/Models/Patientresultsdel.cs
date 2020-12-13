using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientresultsdel
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
        public DateTime TransTime { get; set; }
        public string Sbranchcode { get; set; }
        public string Usercodedel { get; set; }
        public DateTime TransTimedel { get; set; }
        public string Deltype { get; set; }
    }
}
