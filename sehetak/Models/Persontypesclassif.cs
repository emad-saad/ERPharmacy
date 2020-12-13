using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Persontypesclassif
    {
        public string Ptcode { get; set; }
        public string Ptclassifcode { get; set; }
        public string Ptclassifdescr { get; set; }
        public int? SortOrder { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public decimal? HawafezF1 { get; set; }
    }
}
