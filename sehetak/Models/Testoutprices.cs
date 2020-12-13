using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Testoutprices
    {
        public int Testcode { get; set; }
        public string Outlabcode { get; set; }
        public decimal Testoutprice { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public string Outlabblock { get; set; }
        public string Branchcode { get; set; }
        public byte? Outlabdef { get; set; }
    }
}
