using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Diseasesections
    {
        public int DisSecId { get; set; }
        public int DisSecCode { get; set; }
        public string DisSecName { get; set; }
        public string DisSecAname { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
