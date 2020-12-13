using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Custnosaleitems
    {
        public string Personcode { get; set; }
        public string Familycode { get; set; }
        public byte AllowSell { get; set; }
        public DateTime CustLastupdate { get; set; }
    }
}
