using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Emppausesalary
    {
        public string Branchcode { get; set; }
        public DateTime TransTime { get; set; }
        public string Usercode { get; set; }
        public byte Pausesalary { get; set; }
        public string Pausecomment { get; set; }
    }
}
