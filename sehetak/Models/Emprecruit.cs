using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Emprecruit
    {
        public string Personcode { get; set; }
        public string Recruitcode { get; set; }
        public byte Recruitreceived { get; set; }
        public DateTime? Recruitreceivedate { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
    }
}
