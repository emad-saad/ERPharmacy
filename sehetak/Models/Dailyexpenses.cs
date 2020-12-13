using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Dailyexpenses
    {
        public string Branchcode { get; set; }
        public DateTime Expensedate { get; set; }
        public string Intervalcode { get; set; }
        public int Expcode { get; set; }
        public decimal Expvalue { get; set; }
        public string Expcomment { get; set; }
        public int Cheqsno { get; set; }
        public int DaySno { get; set; }
        public string Custcode { get; set; }
        public byte? Expsource { get; set; }
        public string Costcentercode { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Branchcode2 { get; set; }
        public string Expusercode { get; set; }
    }
}
