using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class IcuNursingmedicationshee
    {
        public string Pic { get; set; }
        public DateTime Transdate { get; set; }
        public DateTime Transtime { get; set; }
        public string Bed { get; set; }
        public int Medicatecode { get; set; }
        public int Dose { get; set; }
        public short? Routecode { get; set; }
        public string Observation { get; set; }
        public string Signature { get; set; }
    }
}
