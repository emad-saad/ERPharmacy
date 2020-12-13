using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empspecialdeduct
    {
        public string Personcode { get; set; }
        public DateTime Deductdate { get; set; }
        public string Deductitem { get; set; }
        public decimal Deductvalue { get; set; }
        public string Deductcomments { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
