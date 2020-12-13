using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Itemstoreclassif
    {
        public string Itemcode { get; set; }
        public string Storesclassif { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public byte Blockclassif { get; set; }
    }
}
