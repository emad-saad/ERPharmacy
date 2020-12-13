using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empexperiences
    {
        public string Empcode { get; set; }
        public DateTime Expsdate { get; set; }
        public DateTime? Expfdate { get; set; }
        public string Expplace { get; set; }
        public string Expdescr { get; set; }
        public string Exptitle { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public decimal Empexpyears { get; set; }
        public decimal Empexpyearsapp { get; set; }
    }
}
