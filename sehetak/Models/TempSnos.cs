using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class TempSnos
    {
        public string Usercode { get; set; }
        public decimal PosShiftclosing { get; set; }
        public decimal UserCashinhand { get; set; }
        public int UserCheqsno { get; set; }
        public int UserPcode { get; set; }
        public int UserIsno { get; set; }
        public int UserRsno { get; set; }
    }
}
