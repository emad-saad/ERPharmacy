using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class CommunicTselects
    {
        public string Branchcode { get; set; }
        public int Tsno { get; set; }
        public DateTime Communictime { get; set; }
        public byte Communicact7 { get; set; }
        public byte Communicact1 { get; set; }
        public byte Communicact2 { get; set; }
        public byte Communicact3 { get; set; }
        public byte Communicact4 { get; set; }
        public byte Communicact5 { get; set; }
        public byte Communicact6 { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime TableDumped { get; set; }
    }
}
