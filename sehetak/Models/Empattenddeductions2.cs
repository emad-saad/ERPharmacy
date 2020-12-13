using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empattenddeductions2
    {
        public string Ptclassifcode { get; set; }
        public decimal Latefrom { get; set; }
        public decimal Lateto { get; set; }
        public decimal Deductionofdays { get; set; }
        public string Ruletype { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public decimal Extrarateoffdays { get; set; }
        public decimal Extraratenightshift { get; set; }
        public decimal Extrarateleavedays { get; set; }
    }
}
