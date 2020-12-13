using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Jocomments
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public short Commentsno { get; set; }
        public string Ptcomments { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
