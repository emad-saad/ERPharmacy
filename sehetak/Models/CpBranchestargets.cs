using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class CpBranchestargets
    {
        public string Branchcode { get; set; }
        public short Yearno { get; set; }
        public short Monthno { get; set; }
        public decimal MoneyTargetf { get; set; }
        public decimal MoneyTargett { get; set; }
        public decimal Hafezp { get; set; }
        public string RecProtect { get; set; }
    }
}
