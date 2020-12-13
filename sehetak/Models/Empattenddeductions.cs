using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empattenddeductions
    {
        public decimal Latefrom { get; set; }
        public decimal Lateto { get; set; }
        public decimal Deductionofdays { get; set; }
        public string Ruletype { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public int? Penaltycode { get; set; }
    }
}
