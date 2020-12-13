using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Expenses
    {
        public int Expcode { get; set; }
        public string Expdescr { get; set; }
        public int Expclassifcode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Exptype { get; set; }
        public string Expaccitemcode { get; set; }
        public byte Allmonths { get; set; }
    }
}
