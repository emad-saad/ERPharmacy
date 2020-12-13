using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class MachineSamples
    {
        public int Samplecode { get; set; }
        public string Machinecode { get; set; }
        public string Machinesamplecode { get; set; }
        public byte MachineTestLocked { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
    }
}
