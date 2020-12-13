using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Branchesintervals
    {
        public string Branchcode { get; set; }
        public string Intervalcode { get; set; }
        public string Personcode { get; set; }
        public DateTime Hourofday { get; set; }
        public string Samedayhours { get; set; }
        public int HourOfDay1 { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
