using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Branchesgeography
    {
        public string Branchcode { get; set; }
        public string Personcode { get; set; }
        public short Personorder { get; set; }
        public short Personsal { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public byte Branchlocked { get; set; }
    }
}
