using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empbuys
    {
        public string Personcode { get; set; }
        public DateTime Empbuydate { get; set; }
        public decimal Empbuyvalue { get; set; }
        public string Empbuycomment { get; set; }
    }
}
