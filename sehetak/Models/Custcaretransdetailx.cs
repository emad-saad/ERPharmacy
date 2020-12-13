using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Custcaretransdetailx
    {
        public string Branchcode { get; set; }
        public int Serviceorderno { get; set; }
        public string Sordercomments { get; set; }
        public int Detailsno { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public byte Detailcancelled { get; set; }
        public string Cancelusercode { get; set; }
        public DateTime? CanceltransTime { get; set; }
    }
}
