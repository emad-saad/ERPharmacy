using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Pcategorybranches
    {
        public short Pcategorycode { get; set; }
        public string Branchcode { get; set; }
        public string Pcatbranchdel { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
    }
}
