using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class MotalbaClab
    {
        public int Motalbano { get; set; }
        public string Custcode { get; set; }
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public DateTime Patientdate { get; set; }
        public DateTime Motalbasdate { get; set; }
        public DateTime Motalbafdate { get; set; }
        public decimal Docvaluerequired { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public decimal DocvalueGrandtotal { get; set; }
        public string Branchcode2 { get; set; }
        public string Doccode { get; set; }
        public decimal? Docnumber { get; set; }
        public short? MotalbaDocorder { get; set; }
    }
}
