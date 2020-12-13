using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Branchesspends
    {
        public string Branchcode { get; set; }
        public DateTime Spendsdate { get; set; }
        public string Intervalcode { get; set; }
        public decimal Spentcash { get; set; }
        public string Spentdescr { get; set; }
    }
}
