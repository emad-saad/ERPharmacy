using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class TempEmpsalguide
    {
        public string Usercode { get; set; }
        public string Branchname { get; set; }
        public string Ptclassifdescr { get; set; }
        public int Totcount { get; set; }
        public decimal Minsal { get; set; }
        public decimal Maxsal { get; set; }
        public decimal Avgsal { get; set; }
        public string Basesaltype { get; set; }
    }
}
