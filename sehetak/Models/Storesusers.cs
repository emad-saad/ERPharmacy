using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Storesusers
    {
        public string Storecode { get; set; }
        public string Personcode { get; set; }
        public byte Personblocked { get; set; }
        public string Usercode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Storecomment { get; set; }
    }
}
