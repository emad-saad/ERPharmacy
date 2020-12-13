using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Preparations
    {
        public int Prepcode { get; set; }
        public string Prepdescr { get; set; }
        public short Prepanswer { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Prepedescr { get; set; }
        public byte Preptype { get; set; }
        public string Prepsex { get; set; }
    }
}
