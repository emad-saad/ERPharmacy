using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Stktransmmcomm
    {
        public string Branchcode { get; set; }
        public short Commyr { get; set; }
        public byte Commmonth { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
