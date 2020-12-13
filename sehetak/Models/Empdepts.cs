using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empdepts
    {
        public short Deptcode { get; set; }
        public string Deptdescr { get; set; }
        public int? SortOrder { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Jhccode { get; set; }
        public string Jhcl1 { get; set; }
        public string Jhcl2 { get; set; }
        public string Usercode { get; set; }
        public decimal Salmin { get; set; }
        public decimal Salmax { get; set; }
        public byte? Ismanager { get; set; }
    }
}
