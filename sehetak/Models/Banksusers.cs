using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Banksusers
    {
        public string Bankcode { get; set; }
        public string Personcode { get; set; }
        public byte Personblocked { get; set; }
        public string Usercode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Bankcomment { get; set; }
    }
}
