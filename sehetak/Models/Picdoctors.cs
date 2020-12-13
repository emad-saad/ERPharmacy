using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Picdoctors
    {
        public string Phcode { get; set; }
        public string Refdoctorcode { get; set; }
        public byte Maindoctor { get; set; }
        public string Doctorcomment { get; set; }
        public byte Doctordel { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
