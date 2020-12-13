using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Provinces
    {
        public int Provincecode { get; set; }
        public string Provincename { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public int? Districtcode { get; set; }
    }
}
