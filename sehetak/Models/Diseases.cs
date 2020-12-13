using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Diseases
    {
        public int DisId { get; set; }
        public int DisCode { get; set; }
        public string DisWhoCode { get; set; }
        public int DisSecId { get; set; }
        public int DisGrpId { get; set; }
        public string DisName { get; set; }
        public string DisAname { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
