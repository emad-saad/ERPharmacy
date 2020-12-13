using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class TempAging
    {
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public int AgingDays { get; set; }
        public string AgingDaysDescr { get; set; }
        public string Personcode { get; set; }
        public string Personname { get; set; }
        public decimal TotValue { get; set; }
    }
}
