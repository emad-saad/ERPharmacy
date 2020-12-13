using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Cfarmasetup
    {
        public int Cfsetupcode { get; set; }
        public decimal Cfsetupvalue { get; set; }
        public DateTime? Cfsetupdate { get; set; }
        public string Cfsetuptext { get; set; }
        public string Cfsetuphelp { get; set; }
        public string Cfsetuptype { get; set; }
        public string Cfsetupclassif { get; set; }
        public string Cfsetuptext2 { get; set; }
    }
}
