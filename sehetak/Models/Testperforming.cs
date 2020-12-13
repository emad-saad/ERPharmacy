using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Testperforming
    {
        public int Testcode { get; set; }
        public string Branchcode { get; set; }
        public string Performbranchcode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public short? Performnoofdays { get; set; }
        public byte? Performoutside { get; set; }
    }
}
