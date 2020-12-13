using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Emprelatives
    {
        public string Personcode { get; set; }
        public short Relativesno { get; set; }
        public string Relativecode { get; set; }
        public string Relativename { get; set; }
        public DateTime? Relativedobirth { get; set; }
        public string Relativejob { get; set; }
        public byte Relativevip { get; set; }
        public byte Relativedep { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
    }
}
