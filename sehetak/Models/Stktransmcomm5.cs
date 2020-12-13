using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Stktransmcomm5
    {
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public string Personcode { get; set; }
        public byte Commtype { get; set; }
        public decimal Commvaluetot { get; set; }
        public decimal Commvalueget { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
