using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Costcenters
    {
        public string Costcentercode { get; set; }
        public string Costcenterdescr { get; set; }
        public string Costcenterclassifcode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Ccclosed { get; set; }
        public string Cccusercode { get; set; }
        public DateTime? CcctransTime { get; set; }
    }
}
