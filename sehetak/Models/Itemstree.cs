using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Itemstree
    {
        public byte Cdlevel { get; set; }
        public string Cdlcode { get; set; }
        public string Cdldescr { get; set; }
        public string Cdpcode { get; set; }
        public string Cdcode { get; set; }
        public int SortOrder { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public byte Isblocked { get; set; }
        public string Cdldescrar { get; set; }
    }
}
