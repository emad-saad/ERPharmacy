using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empattendance
    {
        public string Personcode { get; set; }
        public DateTime Attenddate { get; set; }
        public string Empstime { get; set; }
        public string Empftime { get; set; }
        public string Starttime { get; set; }
        public string Finishtime { get; set; }
        public decimal? HoursMissing { get; set; }
        public decimal? HoursExtra { get; set; }
        public decimal? Saltimededuction { get; set; }
        public decimal? Saltimeextra { get; set; }
        public string Attendnote { get; set; }
        public string Leavetype { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
    }
}
