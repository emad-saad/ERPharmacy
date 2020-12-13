using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empyearlyincrease
    {
        public short Empyear { get; set; }
        public string Branchcode { get; set; }
        public decimal Empincreasep { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Empcomments { get; set; }
        public decimal Empincreasevalue { get; set; }
        public decimal Empincreasevalue2 { get; set; }
        public decimal Minvalue { get; set; }
        public decimal Maxvalue { get; set; }
    }
}
