using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Accsysitems
    {
        public int Accitemsno { get; set; }
        public string Acciteml26 { get; set; }
        public string Accitemdescr { get; set; }
        public byte Accitemtype { get; set; }
        public string Mitemsys { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public byte Accsysallow { get; set; }
        public string Usercode { get; set; }
    }
}
