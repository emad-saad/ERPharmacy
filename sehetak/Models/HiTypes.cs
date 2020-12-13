using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class HiTypes
    {
        public string HiTypecode { get; set; }
        public string HiTypedescr { get; set; }
        public short HiMaxitems { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
