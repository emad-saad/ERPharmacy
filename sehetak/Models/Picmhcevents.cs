using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Picmhcevents
    {
        public string Phcode { get; set; }
        public string Mhcl1 { get; set; }
        public short Relativecode { get; set; }
        public string Mhccode { get; set; }
        public DateTime Eventdatetime { get; set; }
        public string Eventby { get; set; }
        public string Eventcomments { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public byte Eventactive { get; set; }
        public DateTime? Eventinactivedate { get; set; }
        public byte? Mhcduration1 { get; set; }
        public byte? Mhcduration2 { get; set; }
        public byte? Mhcrate1 { get; set; }
        public byte? Mhcrate2 { get; set; }
    }
}
