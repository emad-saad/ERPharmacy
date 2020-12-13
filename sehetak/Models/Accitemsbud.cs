using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Accitemsbud
    {
        public string Acciteml1 { get; set; }
        public short Accyear { get; set; }
        public byte Accmonth { get; set; }
        public string Accbudcode { get; set; }
        public string Accitemcode { get; set; }
        public decimal Accitemvalue { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public string Usercode { get; set; }
    }
}
