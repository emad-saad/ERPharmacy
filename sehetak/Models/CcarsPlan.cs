using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class CcarsPlan
    {
        public string Branchcode { get; set; }
        public DateTime Scheduledate { get; set; }
        public int Schedulesno { get; set; }
        public string Carno { get; set; }
        public int Carorder { get; set; }
        public int Tripsno { get; set; }
        public short Tripcode { get; set; }
        public string Tripso { get; set; }
        public int Triporder { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
