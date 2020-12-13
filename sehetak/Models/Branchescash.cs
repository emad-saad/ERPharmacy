using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Branchescash
    {
        public string Branchcode { get; set; }
        public DateTime Cashdate { get; set; }
        public string Intervalcode { get; set; }
        public decimal Salescash { get; set; }
        public decimal Spentcash { get; set; }
        public string Personcode { get; set; }
    }
}
