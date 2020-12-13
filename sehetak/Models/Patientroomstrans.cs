using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientroomstrans
    {
        public string Branchcode { get; set; }
        public string Phcode { get; set; }
        public string Hroom { get; set; }
        public DateTime Hroomsdate { get; set; }
        public DateTime? Hroomfdate { get; set; }
        public string Roomcomment { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
    }
}
