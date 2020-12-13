using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Tripsdata
    {
        public short Tripcode { get; set; }
        public string Tripname { get; set; }
        public string Triptype { get; set; }
        public string Tripsymbol { get; set; }
        public string Tripitemcode { get; set; }
        public string Branchcode { get; set; }
        public short Tripstddistance { get; set; }
        public short Tripstdtime { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
