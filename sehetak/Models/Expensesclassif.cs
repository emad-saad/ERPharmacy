using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Expensesclassif
    {
        public int Expclassifcode { get; set; }
        public string Expclassifdescr { get; set; }
        public string Exptype { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
