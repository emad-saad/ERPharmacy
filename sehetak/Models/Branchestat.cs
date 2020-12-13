using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Branchestat
    {
        public string Branchcode { get; set; }
        public short Tatpos { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public string Usercode { get; set; }
        public byte Posdel { get; set; }
    }
}
