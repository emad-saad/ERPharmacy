using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientdeletion
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public DateTime TransTime { get; set; }
        public string Usercode { get; set; }
        public string Usercomment { get; set; }
        public byte TransType { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Ptdelreason { get; set; }
        public int Testcode { get; set; }
        public int? Bosno { get; set; }
    }
}
