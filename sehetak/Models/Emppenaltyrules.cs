using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Emppenaltyrules
    {
        public int Penaltycode { get; set; }
        public string Penaltyname { get; set; }
        public string Penaltydescr { get; set; }
        public decimal Penaltydays1 { get; set; }
        public decimal Penaltyvalue1 { get; set; }
        public decimal Penaltydays2 { get; set; }
        public decimal Penaltyvalue2 { get; set; }
        public decimal Penaltydays3 { get; set; }
        public decimal Penaltyvalue3 { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public decimal Penaltydays4 { get; set; }
        public decimal Penaltyvalue4 { get; set; }
        public string Penaltyclassif { get; set; }
        public byte Penaltyruleblock { get; set; }
        public byte Attendrule { get; set; }
        public byte Editrule { get; set; }
    }
}
