using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Localcustomerspoints
    {
        public string Branchcode { get; set; }
        public string Phcode { get; set; }
        public int Totpoints { get; set; }
        public DateTime? TableDumped { get; set; }
        public int? Conpoints { get; set; }
    }
}
