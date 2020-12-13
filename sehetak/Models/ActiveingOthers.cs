using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class ActiveingOthers
    {
        public int Aicode { get; set; }
        public byte Aipregnancy { get; set; }
        public byte Aiabuse { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Usercode { get; set; }
        public byte? Ailactation { get; set; }
    }
}
