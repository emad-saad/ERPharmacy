using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Chequeslevels
    {
        public string Personcode { get; set; }
        public decimal Leveldirectcash { get; set; }
        public decimal Leveldirectcredit { get; set; }
        public decimal Levelindirectcash { get; set; }
        public decimal Levelindirectcredit { get; set; }
        public string Levelusercode { get; set; }
        public DateTime LeveltransTime { get; set; }
        public byte Personblock { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Levelcomments { get; set; }
        public string Branchcode { get; set; }
    }
}
