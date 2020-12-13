using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empexchanges
    {
        public string Empcode { get; set; }
        public DateTime Empdate { get; set; }
        public DateTime Empstime { get; set; }
        public DateTime Empftime { get; set; }
        public string Empcode2 { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Exchcomment { get; set; }
        public byte Exchdel { get; set; }
        public string Exchdelusercode { get; set; }
        public DateTime? ExchdeltransTime { get; set; }
    }
}
