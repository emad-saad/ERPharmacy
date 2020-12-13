using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empplan
    {
        public short Planyear { get; set; }
        public byte Planmonth { get; set; }
        public string Branchcode { get; set; }
        public string Jhccode { get; set; }
        public string Jobcode { get; set; }
        public short Planno { get; set; }
        public short Actualno { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
    }
}
