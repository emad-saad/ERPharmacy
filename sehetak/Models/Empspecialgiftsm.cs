using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empspecialgiftsm
    {
        public int Specialgiftsno { get; set; }
        public DateTime Specialgiftdate { get; set; }
        public string Specialgiftdescr { get; set; }
        public decimal Specialgiftvalue { get; set; }
        public int Empfromsdate { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public string Comments { get; set; }
        public string Specialgiftclosed { get; set; }
        public decimal Minvalue { get; set; }
        public decimal Maxvalue { get; set; }
    }
}
