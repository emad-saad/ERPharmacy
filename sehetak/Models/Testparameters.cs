using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Testparameters
    {
        public int Testcode { get; set; }
        public int Parametercode { get; set; }
        public string Parametername { get; set; }
        public short Paramtypecode { get; set; }
        public short? Parameterunit { get; set; }
        public short? TestparameterOrder { get; set; }
        public string Machinecode { get; set; }
        public short? Paramno { get; set; }
        public string MachineSymbol { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public byte Pbold { get; set; }
        public byte Punderline { get; set; }
        public byte Pitalic { get; set; }
        public short Pfontsize { get; set; }
        public string Testparamdel { get; set; }
        public short? Samplecode { get; set; }
    }
}
