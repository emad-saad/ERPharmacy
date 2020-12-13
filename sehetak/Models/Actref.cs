using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Actref
    {
        public string Actcode { get; set; }
        public string Refactcode { get; set; }
        public byte Refactblock { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public string Usercode { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
