using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Postext
    {
        public string Branchcode { get; set; }
        public short Poslinetype { get; set; }
        public short Poslineno { get; set; }
        public string Poslinetext { get; set; }
        public string Usercode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
