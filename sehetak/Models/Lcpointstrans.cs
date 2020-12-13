using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Lcpointstrans
    {
        public string Branchcode { get; set; }
        public string Phcode { get; set; }
        public int Transsno { get; set; }
        public int Totpoints { get; set; }
        public int Conpoints { get; set; }
        public string Phcodestatus { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
        public int Totpointsold { get; set; }
        public int Conpointsold { get; set; }
    }
}
