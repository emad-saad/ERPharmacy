using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Testsconflicts
    {
        public int Testcode { get; set; }
        public int Testcode2 { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Conflictcomment { get; set; }
    }
}
