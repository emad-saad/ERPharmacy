using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empmilitary
    {
        public string Empcode { get; set; }
        public byte Militarystatuscode { get; set; }
        public DateTime? Militarysdate { get; set; }
        public DateTime? Militaryfdate { get; set; }
        public short? MilitaryDays { get; set; }
        public short? MilitaryMonths { get; set; }
        public short? MilitaryYears { get; set; }
        public string Certificateno { get; set; }
        public DateTime? Certificatedate { get; set; }
        public byte? Militarygradecode { get; set; }
        public string Militarycomments { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public short? Empfreereason { get; set; }
        public DateTime? Empfreesdate { get; set; }
        public DateTime? Empfreeedate { get; set; }
    }
}
