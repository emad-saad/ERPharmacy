using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Persontypes
    {
        public string Ptcode { get; set; }
        public string Ptdescr { get; set; }
        public string Lastpersoncode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public byte Ptcodeblocked { get; set; }
        public string Ptedescr { get; set; }
    }
}
