using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Stores
    {
        public string Storecode { get; set; }
        public string Storename { get; set; }
        public string Storeaddress { get; set; }
        public string Acciteml5 { get; set; }
        public string Storesclassif { get; set; }
        public short? SortOrder { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Accitemcode { get; set; }
        public byte? Storerealbal { get; set; }
        public string Pstorecode { get; set; }
        public string Costcentercode { get; set; }
        public string Icuprice { get; set; }
    }
}
