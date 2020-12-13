using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Profilesprices
    {
        public int Profilecode { get; set; }
        public int Pcategorycode { get; set; }
        public decimal Profiletotprice { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
