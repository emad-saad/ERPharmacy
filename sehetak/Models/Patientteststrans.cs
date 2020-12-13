using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientteststrans
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public int Transsno { get; set; }
        public DateTime Testrundate { get; set; }
        public DateTime Testresultdate { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime Testtopatientdate { get; set; }
        public byte Testsamplenotyet { get; set; }
        public byte Testsample { get; set; }
        public string Transcomments { get; set; }
        public DateTime? TestsampledateOrig { get; set; }
    }
}
