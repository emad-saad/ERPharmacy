using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Parameterranges
    {
        public int Parametercode { get; set; }
        public decimal Agefrom { get; set; }
        public decimal Ageto { get; set; }
        public string Sex { get; set; }
        public string Minvalue { get; set; }
        public string Maxvalue { get; set; }
        public string Parameterdescr { get; set; }
        public int ParameterrangeCount { get; set; }
        public string ParameterrangeGlobal { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Testparamdel { get; set; }
        public string Minvaluepos { get; set; }
        public string Maxvaluepos { get; set; }
        public string Branchcode { get; set; }
        public string Minvaluecrit { get; set; }
        public string Maxvaluecrit { get; set; }
    }
}
