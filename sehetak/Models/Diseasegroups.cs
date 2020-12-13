using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Diseasegroups
    {
        public int DisGrpId { get; set; }
        public int DisGrpCode { get; set; }
        public int DisSecId { get; set; }
        public string DisGrpName { get; set; }
        public string DisGrpAname { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
