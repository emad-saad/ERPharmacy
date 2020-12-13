using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Usergroups
    {
        public int Usergroup { get; set; }
        public string Groupdescr { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public byte Groupblocked { get; set; }
    }
}
