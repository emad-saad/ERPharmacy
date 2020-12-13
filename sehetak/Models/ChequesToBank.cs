using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class ChequesToBank
    {
        public int Cheqsno { get; set; }
        public DateTime Cheqtobankdate { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public string Bankcode { get; set; }
        public string Tobanknote { get; set; }
        public string Branchcode { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Bankcodeorig { get; set; }
    }
}
