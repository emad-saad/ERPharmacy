using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empnightshifts
    {
        public string Empcode { get; set; }
        public DateTime Nsdate { get; set; }
        public string Nsstime { get; set; }
        public string Nsftime { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public byte Nsblocked { get; set; }
        public string Nscomment { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
