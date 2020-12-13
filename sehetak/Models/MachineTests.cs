using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class MachineTests
    {
        public int Parametercode { get; set; }
        public string Machinecode { get; set; }
        public string Machineparamcode { get; set; }
        public byte MachineTestLocked { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public string Machineparamcodeout { get; set; }
        public byte? Roundparamcodeout { get; set; }
    }
}
