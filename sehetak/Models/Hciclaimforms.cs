using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Hciclaimforms
    {
        public string Personcode { get; set; }
        public int Receivesno { get; set; }
        public DateTime Receivedate { get; set; }
        public short Noofforms { get; set; }
        public int Claimsno1 { get; set; }
        public int Claimsno2 { get; set; }
        public string Receivedby { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public byte Claimdel { get; set; }
        public string Claimcomment { get; set; }
    }
}
