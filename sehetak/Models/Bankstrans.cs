using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Bankstrans
    {
        public string Bankcode { get; set; }
        public DateTime Transdate { get; set; }
        public string Transdescr { get; set; }
        public decimal Transcredit { get; set; }
        public decimal Transdebit { get; set; }
        public int TransCounter { get; set; }
        public string TransNote { get; set; }
        public string Usercode { get; set; }
    }
}
