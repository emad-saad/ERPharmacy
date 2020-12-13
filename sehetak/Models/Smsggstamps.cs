using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Smsggstamps
    {
        public string Branchcode { get; set; }
        public int Msgsno { get; set; }
        public string ToUserid { get; set; }
        public byte Msgtranstype { get; set; }
        public string Msgtransbranch { get; set; }
        public DateTime Msgtranstime { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
