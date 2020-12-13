using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Personsdatastaff
    {
        public string Personcode { get; set; }
        public short Personsno { get; set; }
        public string Staffcode { get; set; }
        public byte Personblocked { get; set; }
        public byte Personmain { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public string Usercode { get; set; }
        public string Personcomment { get; set; }
    }
}
