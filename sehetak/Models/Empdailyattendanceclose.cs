using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empdailyattendanceclose
    {
        public string Branchcode { get; set; }
        public DateTime Sdate { get; set; }
        public DateTime Fdate { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
