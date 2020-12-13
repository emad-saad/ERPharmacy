using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class CustnosaleitemsHist
    {
        public DateTime Transdate { get; set; }
        public string Personcode { get; set; }
        public string Familycode { get; set; }
        public byte AllowSell { get; set; }
        public string Usercode { get; set; }
    }
}
