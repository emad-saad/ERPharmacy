using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Itemsimages
    {
        public string Itemcode { get; set; }
        public byte[] Itempicture { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
