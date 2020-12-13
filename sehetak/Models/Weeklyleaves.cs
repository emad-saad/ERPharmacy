using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Weeklyleaves
    {
        public string Personcode { get; set; }
        public string Dayno { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Weeklyblocked { get; set; }
    }
}
