using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class MachineResults
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public string Machinecode { get; set; }
        public string Machinetestcode { get; set; }
        public DateTime Machinetranstime { get; set; }
        public string Resultstring { get; set; }
        public string Machinesamplecode { get; set; }
        public int? Testcode { get; set; }
        public int? Parametercode { get; set; }
        public string Resultvalue { get; set; }
        public string Resultunit { get; set; }
        public string Resultnormal1 { get; set; }
        public string Resultnormal2 { get; set; }
        public string Resultcomment { get; set; }
        public string Retstat { get; set; }
        public string VerBranchL1 { get; set; }
        public short? Samplecode { get; set; }
        public byte? Testrerun { get; set; }
        public byte? Resulttype { get; set; }
    }
}
