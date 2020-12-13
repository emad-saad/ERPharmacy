using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Personsopenbal
    {
        public string Personcode { get; set; }
        public decimal Personopendebit { get; set; }
        public decimal Personopencredit { get; set; }
        public DateTime Personopendate { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public string Ptcode { get; set; }
        public string Opentrans { get; set; }
    }
}
