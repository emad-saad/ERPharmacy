using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class CpBrancheshawafez
    {
        public string Branchcode { get; set; }
        public short Yearno { get; set; }
        public short Monthno { get; set; }
        public decimal MoneyReal { get; set; }
        public decimal Branchtothafez { get; set; }
        public decimal Branchtotpoints { get; set; }
        public string RecProtect { get; set; }
    }
}
