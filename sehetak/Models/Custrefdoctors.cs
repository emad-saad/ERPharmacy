using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Custrefdoctors
    {
        public string Refdoctorcode { get; set; }
        public string Custcode { get; set; }
        public string Custcomment { get; set; }
        public byte Doctortime1 { get; set; }
        public byte Doctortime2 { get; set; }
        public byte Doctortime3 { get; set; }
        public string Usercode { get; set; }
        public byte Custcodelock { get; set; }
        public string UsercodeLock { get; set; }
        public DateTime? TransTimeLock { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
