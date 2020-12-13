using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Managerdiscount
    {
        public string Personcode { get; set; }
        public decimal MaxCustdiscp { get; set; }
        public string Branchcode { get; set; }
        public DateTime? MdiscLastupdate { get; set; }
    }
}
