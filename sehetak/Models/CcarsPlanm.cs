using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class CcarsPlanm
    {
        public string Branchcode { get; set; }
        public DateTime Scheduledate { get; set; }
        public int Schedulesno { get; set; }
        public short Carsfree { get; set; }
        public short Tripstorent { get; set; }
        public decimal Planincome { get; set; }
        public decimal Planrent { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
