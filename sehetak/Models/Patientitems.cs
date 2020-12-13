using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientitems
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public string Itemcode { get; set; }
        public string ItemComments { get; set; }
        public short? Itemqty { get; set; }
        public string Itemunit { get; set; }
        public short? Itemfreq { get; set; }
        public short? Noofdays { get; set; }
        public decimal Transqty { get; set; }
        public decimal Itemsaleprice { get; set; }
    }
}
