using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class BanksSafePending
    {
        public string Bankcode { get; set; }
        public int PendingSno { get; set; }
        public DateTime GivenDate { get; set; }
        public string GivenTo { get; set; }
        public decimal Cashvalue { get; set; }
        public byte Pendingstatus { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Pendingnote { get; set; }
        public string ClosedUsercode { get; set; }
        public DateTime? ClosedTransTime { get; set; }
        public string GivenToEmpcode { get; set; }
        public byte? Incusttype { get; set; }
        public DateTime? Tempduedate { get; set; }
    }
}
