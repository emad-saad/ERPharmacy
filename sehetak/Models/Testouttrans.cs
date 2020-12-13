using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Testouttrans
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public int Transsno { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public byte Testout { get; set; }
        public string Transcomments { get; set; }
        public string Outlabcode { get; set; }
        public decimal Testoutprice { get; set; }
        public DateTime Testoutgetdate { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
