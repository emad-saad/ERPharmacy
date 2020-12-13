using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Cfarmalog
    {
        public DateTime TransTime { get; set; }
        public string Transtype { get; set; }
        public string Transver { get; set; }
        public short Transsno { get; set; }
        public DateTime RunTime { get; set; }
        public short RunResult { get; set; }
        public string Runcomment { get; set; }
        public string Transbuild { get; set; }
        public string Runcomment2 { get; set; }
    }
}
