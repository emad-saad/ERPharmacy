using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Itembarcode
    {
        public string Itemcode { get; set; }
        public string Itembarcode1 { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Usercode { get; set; }
        public string Mainbarcode { get; set; }
        public string Blockbarcode { get; set; }
        public string Delusercode { get; set; }
        public DateTime? DeltransTime { get; set; }
    }
}
