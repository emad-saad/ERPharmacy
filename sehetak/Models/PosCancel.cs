using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class PosCancel
    {
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public string Itemcode { get; set; }
        public decimal Itemsaleprice { get; set; }
        public decimal Transprice { get; set; }
        public decimal Transqty { get; set; }
        public decimal TranspriceTotal { get; set; }
        public string Custcode { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime TransDate { get; set; }
        public string Mitemname { get; set; }
    }
}
