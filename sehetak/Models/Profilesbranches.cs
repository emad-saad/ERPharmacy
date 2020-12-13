using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Profilesbranches
    {
        public int Profilecode { get; set; }
        public string Branchcode { get; set; }
        public byte Blockrestrict { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
