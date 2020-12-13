using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Custcaretrans
    {
        public string Branchcode { get; set; }
        public int Serviceorderno { get; set; }
        public DateTime Soassignedtotime { get; set; }
        public string Soassignedto { get; set; }
        public DateTime Soassigneddue { get; set; }
        public string Usercode { get; set; }
    }
}
