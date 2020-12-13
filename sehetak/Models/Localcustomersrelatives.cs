using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Localcustomersrelatives
    {
        public string Phcode { get; set; }
        public short Relativesno { get; set; }
        public short Relativecode { get; set; }
        public string Relativename { get; set; }
        public DateTime? Relativedobirth { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
    }
}
