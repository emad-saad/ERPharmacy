using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientpreparations
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Prepcode { get; set; }
        public string Ptanswer { get; set; }
        public DateTime? TableDumped { get; set; }
        public byte? Patientdeleted { get; set; }
    }
}
