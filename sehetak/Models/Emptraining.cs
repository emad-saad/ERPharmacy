using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Emptraining
    {
        public string Empcode { get; set; }
        public string Trainingname { get; set; }
        public DateTime Trainingsdate { get; set; }
        public DateTime Trainingfdate { get; set; }
        public string Trainingplace { get; set; }
        public string Trainingdescr { get; set; }
        public short? Traininggrade { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Trainingtype { get; set; }
        public byte? Trainingplaceclassif { get; set; }
        public short? Traininghours { get; set; }
        public decimal Trainingcost { get; set; }
        public byte? Trainingcostwho { get; set; }
    }
}
