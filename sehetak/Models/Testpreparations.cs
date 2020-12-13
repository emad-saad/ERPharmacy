using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Testpreparations
    {
        public int Testcode { get; set; }
        public int Prepcode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public short? Testpreporder { get; set; }
        public byte? Prepbold { get; set; }
        public byte? Prepunderline { get; set; }
        public byte Preptype { get; set; }
    }
}
