using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Smsggorders
    {
        public string Branchcode { get; set; }
        public int Msgsno { get; set; }
        public string ToUserid { get; set; }
        public string Msgreceivedbranch { get; set; }
        public DateTime? Msgreceivedtime { get; set; }
        public DateTime? Msgreadtime { get; set; }
        public DateTime? TableDumped { get; set; }
        public DateTime? TableDumpedhq { get; set; }
    }
}
