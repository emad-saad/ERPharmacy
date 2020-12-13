using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Testgroups
    {
        public int Testcode { get; set; }
        public string Testgroup { get; set; }
        public byte Testgroupblock { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public string Usercode { get; set; }
    }
}
