using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Custcancelsno
    {
        public string Custcode { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public int Sno1 { get; set; }
        public int Sno2 { get; set; }
        public string Cancelcomment { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
