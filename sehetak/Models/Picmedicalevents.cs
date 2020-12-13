using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Picmedicalevents
    {
        public string Phcode { get; set; }
        public string Eventdescr { get; set; }
        public DateTime EventdatePlan { get; set; }
        public DateTime? EventdateReal { get; set; }
        public string Eventcomments { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public string Usercode2 { get; set; }
        public DateTime? TransTime2 { get; set; }
    }
}
