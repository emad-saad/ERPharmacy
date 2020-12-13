using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Returnsreasons
    {
        public decimal Retreasoncode { get; set; }
        public string Retreasondescr { get; set; }
        public decimal Retclassifcode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
