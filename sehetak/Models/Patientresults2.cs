using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientresults2
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public int Commentlineno { get; set; }
        public string Linecomment { get; set; }
        public byte Linebold { get; set; }
        public byte Lineunderline { get; set; }
        public byte Lineitalic { get; set; }
        public short Linefontsize { get; set; }
        public byte Linenooftabs { get; set; }
        public byte Lineprotected { get; set; }
        public string Usercode { get; set; }
        public string Phcode { get; set; }
        public byte? Resultsource { get; set; }
    }
}
