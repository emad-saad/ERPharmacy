using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Wusers
    {
        public string Userid { get; set; }
        public string Userpasswd { get; set; }
        public string Ptcode { get; set; }
        public DateTime Userexpiry { get; set; }
        public string Entryuser { get; set; }
        public DateTime TransTime { get; set; }
        public string Pic { get; set; }
        public string Vf1 { get; set; }
        public string Vf2 { get; set; }
        public string Vf3 { get; set; }
        public int Userno { get; set; }
        public int Querydays { get; set; }
    }
}
