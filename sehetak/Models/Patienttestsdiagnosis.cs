using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patienttestsdiagnosis
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public short Testdiagnosiscode { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
