using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class ItemsChangefollow
    {
        public string Itemcode { get; set; }
        public string Modelcode { get; set; }
        public byte Followtype { get; set; }
        public int Changevalue { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
