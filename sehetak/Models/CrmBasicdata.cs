using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class CrmBasicdata
    {
        public int Crmcode { get; set; }
        public short Crmcodeclassif { get; set; }
        public string Crmcodeclassifdescr { get; set; }
        public short? Crmcodeclassif1 { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
