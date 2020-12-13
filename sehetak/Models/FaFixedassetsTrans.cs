using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class FaFixedassetsTrans
    {
        public int Facode { get; set; }
        public string Faname { get; set; }
        public string Branchcode { get; set; }
        public string Locationcode { get; set; }
        public string Holdercode { get; set; }
        public DateTime? FaEnddate { get; set; }
        public string Fastatus { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Facomments { get; set; }
        public string OrigBranchcode { get; set; }
        public byte? FaEndreason { get; set; }
        public int? Expcode { get; set; }
        public string Costcentercode { get; set; }
        public DateTime? Endwarrantydate { get; set; }
        public string Fasno { get; set; }
    }
}
