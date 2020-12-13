using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Smsggdata
    {
        public string Branchcode { get; set; }
        public int Msgsno { get; set; }
        public string FromUserid { get; set; }
        public DateTime Msgtime { get; set; }
        public short Msgclassif { get; set; }
        public string Msgtitle { get; set; }
        public string Msgtext { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
