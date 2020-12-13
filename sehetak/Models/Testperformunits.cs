using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Testperformunits
    {
        public int Testcode { get; set; }
        public short Performlabunitcode { get; set; }
        public byte Performunitlock { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public string Usercode { get; set; }
    }
}
