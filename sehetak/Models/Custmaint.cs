using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Custmaint
    {
        public string Branchcode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public string Itemcode { get; set; }
        public string ItempartNo { get; set; }
    }
}
