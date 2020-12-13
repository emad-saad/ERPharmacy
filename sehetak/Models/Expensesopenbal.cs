using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Expensesopenbal
    {
        public string Personcode { get; set; }
        public int Expcode { get; set; }
        public decimal Expopendebit { get; set; }
        public decimal Expopencredit { get; set; }
        public DateTime Expopendate { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Openbaltype { get; set; }
        public string Bankcode { get; set; }
        public DateTime? Cheqdate { get; set; }
        public string Opentrans { get; set; }
    }
}
