using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class RefdoctorsDeal
    {
        public string Refdoctorcode { get; set; }
        public string Personcode { get; set; }
        public int Testcode { get; set; }
        public decimal RefdoctorPercent { get; set; }
        public decimal RefdoctorBonus { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public byte RefdoctorPercentv { get; set; }
        public byte RefdoctorBonusv { get; set; }
    }
}
