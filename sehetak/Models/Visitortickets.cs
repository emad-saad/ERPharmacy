using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Visitortickets
    {
        public string Branchcode { get; set; }
        public DateTime Ticketdate { get; set; }
        public int Ticketsno { get; set; }
        public DateTime TransTime { get; set; }
        public string Usercode { get; set; }
        public string Branchcode2 { get; set; }
        public int? Patientcode { get; set; }
    }
}
