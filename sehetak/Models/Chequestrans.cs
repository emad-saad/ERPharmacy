using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Chequestrans
    {
        public int Cheqsno { get; set; }
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public decimal Docvaluepaid { get; set; }
        public decimal Docvaluepaynow { get; set; }
        public string Usercode { get; set; }
        public string Cheqbranchcode { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
