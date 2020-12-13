using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Itemsimports
    {
        public string Branchcode { get; set; }
        public int Importsno { get; set; }
        public short Importlineno { get; set; }
        public string Itemcode { get; set; }
        public decimal Itemqty { get; set; }
        public DateTime? Itemexpirydate { get; set; }
        public byte Bcurrency { get; set; }
        public decimal Bcrate { get; set; }
        public decimal Itemunitcostbc { get; set; }
        public decimal Itemtotcostbc { get; set; }
        public decimal Itemunitcostlc { get; set; }
        public decimal Itemtotcostlc { get; set; }
        public decimal ImportBcfactor { get; set; }
        public decimal ImportItemtotcostlc { get; set; }
        public decimal ImportItemunitcostlc { get; set; }
    }
}
