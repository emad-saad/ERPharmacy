using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientvcomments
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public string Visitcomments { get; set; }
        public DateTime? TableDumped { get; set; }
        public DateTime TransTime { get; set; }
        public string Usercode { get; set; }
    }
}
