using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Diseasesdata
    {
        public int DisId { get; set; }
        public string DisInc { get; set; }
        public string DisExc { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
