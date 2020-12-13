using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Testitems
    {
        public int Testcode { get; set; }
        public string Itemcode { get; set; }
        public decimal Itemqty { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Branchcode { get; set; }
        public byte Samplecon { get; set; }
        public byte Uniqueconsumable { get; set; }
        public byte Uniqueuconsumable { get; set; }
    }
}
