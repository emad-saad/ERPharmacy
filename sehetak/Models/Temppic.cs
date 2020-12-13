using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Temppic
    {
        public string Phcode { get; set; }
        public string Usercode { get; set; }
        public DateTime Patientdate { get; set; }
        public int Testcode { get; set; }
        public int Linesno { get; set; }
        public byte Testtype { get; set; }
        public string Testname { get; set; }
        public decimal Testprice { get; set; }
    }
}
