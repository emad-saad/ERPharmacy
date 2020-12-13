using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Motalba
    {
        public string Personcode { get; set; }
        public int Motalbano { get; set; }
        public string Branchcode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Motalbasdate { get; set; }
        public DateTime Motalbafdate { get; set; }
        public DateTime Docdate { get; set; }
        public decimal Docvaluerequired { get; set; }
        public decimal DocvalueGrandtotal { get; set; }
        public short MotalbaDocorder { get; set; }
        public string Doccode { get; set; }
        public DateTime TransTime { get; set; }
        public string Usercode { get; set; }
        public string Branchcode2 { get; set; }
        public int? Patientcode { get; set; }
        public string Ppersoncode { get; set; }
        public byte Invdel { get; set; }
        public string Custbranchcode { get; set; }
    }
}
