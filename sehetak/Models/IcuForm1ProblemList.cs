using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class IcuForm1ProblemList
    {
        public string Pic { get; set; }
        public DateTime Transdate { get; set; }
        public short Sno { get; set; }
        public int? Problemcode { get; set; }
        public string Problemdescr { get; set; }
        public DateTime? ProblemStartDate { get; set; }
        public DateTime? ProblemStartTime { get; set; }
        public DateTime? ProblemEndDate { get; set; }
        public DateTime? ProblemEndTime { get; set; }
        public string Bed { get; set; }
        public int? Consultantcode { get; set; }
    }
}
