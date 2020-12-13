using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Personsdatatax
    {
        public string Phcode { get; set; }
        public string Ptcode { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public string Taxregno { get; set; }
        public string Taxfileno { get; set; }
        public string Taxpayername { get; set; }
        public string Taxpayeraddress { get; set; }
        public string Taxdept { get; set; }
        public string Taxdeptcode { get; set; }
        public string Taxnature { get; set; }
        public string Taxnaturecode { get; set; }
    }
}
