using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Custbranchcontract
    {
        public string Custcode { get; set; }
        public string Custbranchcode { get; set; }
        public string Empstime { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifyLastupdate { get; set; }
        public DateTime Contractstartdate { get; set; }
        public DateTime? Contractenddate { get; set; }
        public decimal Monthlyfees { get; set; }
        public string Bcontractblocked { get; set; }
        public short? Monthlyno { get; set; }
        public string Vf1 { get; set; }
        public string Vf2 { get; set; }
    }
}
