using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class SelectedTests
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public int PrintOrder { get; set; }
    }
}
