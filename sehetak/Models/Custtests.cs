using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Custtests
    {
        public string Custcode { get; set; }
        public int Testcode { get; set; }
        public string Custtestcode { get; set; }
        public string Custtestname { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
