using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Wpatientcomments
    {
        public string Personcode { get; set; }
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public int Commentsno { get; set; }
        public string Comments { get; set; }
    }
}
