using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empdailytimes2
    {
        public string Personcode { get; set; }
        public DateTime Attenddate { get; set; }
        public short Attenddatesno { get; set; }
        public DateTime Empstime { get; set; }
        public DateTime Empftime { get; set; }
        public string Branchcode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Usercode { get; set; }
    }
}
