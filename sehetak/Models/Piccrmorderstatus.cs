using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Piccrmorderstatus
    {
        public string Crmbranchcode { get; set; }
        public int Crmorderno { get; set; }
        public string Branchcode { get; set; }
        public short Orderstatus { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
