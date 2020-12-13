using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Personsdatapersons
    {
        public string Personcode { get; set; }
        public short Personsno { get; set; }
        public string Personname { get; set; }
        public string Personjob { get; set; }
        public byte Personactive { get; set; }
        public byte Personmain { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public string Usercode { get; set; }
        public string Personcomment { get; set; }
    }
}
