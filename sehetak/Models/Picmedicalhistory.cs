using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Picmedicalhistory
    {
        public string Phcode { get; set; }
        public string Medicalhistory { get; set; }
        public string Usercode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
