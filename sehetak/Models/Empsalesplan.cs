using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empsalesplan
    {
        public string Branchcode { get; set; }
        public string Personcode { get; set; }
        public short Planyear { get; set; }
        public byte Planmonth { get; set; }
        public string Custdiscpcode { get; set; }
        public decimal Planquota { get; set; }
        public decimal Plantarget { get; set; }
        public decimal Actualsales { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
    }
}
