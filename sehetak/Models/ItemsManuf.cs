using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class ItemsManuf
    {
        public string Itemcode { get; set; }
        public string Itemcode2 { get; set; }
        public decimal Itemunits { get; set; }
        public string Usercode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
