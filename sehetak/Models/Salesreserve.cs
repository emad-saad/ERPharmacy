using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Salesreserve
    {
        public string Branchcoderes { get; set; }
        public string Doccoderes { get; set; }
        public decimal Docnumberres { get; set; }
        public DateTime Docdateres { get; set; }
        public int Cheqsnores { get; set; }
        public decimal Cheqvalueres { get; set; }
        public decimal? Docnumber { get; set; }
        public DateTime? Docdate { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
