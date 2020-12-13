using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class CarsDailystatus
    {
        public string Branchcode { get; set; }
        public DateTime TransTime { get; set; }
        public string Carno { get; set; }
        public string Carbranchcode { get; set; }
        public DateTime Readingdate { get; set; }
        public int Kmreading { get; set; }
        public string Carstatus { get; set; }
        public string Usercode { get; set; }
        public byte KmreadingEst { get; set; }
        public string Entrybranchcode { get; set; }
        public byte? Carsleep { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
