using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empovertime
    {
        public string Personcode { get; set; }
        public DateTime Actiondate { get; set; }
        public DateTime Otime1 { get; set; }
        public DateTime Otime2 { get; set; }
        public decimal Otrealhours { get; set; }
        public decimal Otfactor { get; set; }
        public decimal Othours { get; set; }
        public decimal Empsalperhour { get; set; }
        public decimal Otmoney { get; set; }
        public string Otapprovedby { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
        public byte Otpaid { get; set; }
        public byte Otoffdays { get; set; }
        public string Otpaidby { get; set; }
        public string Otcomments { get; set; }
    }
}
