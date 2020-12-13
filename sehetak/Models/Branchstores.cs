using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Branchstores
    {
        public string Branchcode { get; set; }
        public string Storecode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Defpos { get; set; }
    }
}
