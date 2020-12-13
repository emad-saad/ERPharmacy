using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Localcustomersdatesdd
    {
        public string Branchcode { get; set; }
        public int Phcodedatesno { get; set; }
        public short Detailsno { get; set; }
        public string Actcomments { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public byte Detailcancelled { get; set; }
        public string Cancelusercode { get; set; }
        public DateTime? CanceltransTime { get; set; }
    }
}
