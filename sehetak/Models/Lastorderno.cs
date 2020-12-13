using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Lastorderno
    {
        public string Branchcode { get; set; }
        public decimal Docnumber { get; set; }
        public decimal Emptaskno { get; set; }
        public decimal Custoffersno { get; set; }
        public decimal Custmaintno { get; set; }
        public int Serviceno { get; set; }
        public int Receiveorderno { get; set; }
        public int Crmorderno { get; set; }
        public int Hcisapp { get; set; }
    }
}
