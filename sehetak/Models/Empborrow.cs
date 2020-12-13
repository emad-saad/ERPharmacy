using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empborrow
    {
        public string Personcode { get; set; }
        public DateTime Borrowdate { get; set; }
        public decimal Borrowvalue { get; set; }
        public string Borrowcomments { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Empcashed { get; set; }
    }
}
