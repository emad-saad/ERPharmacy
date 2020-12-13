using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Itemsproducers
    {
        public string Itemproducercode { get; set; }
        public string Itemproducername { get; set; }
        public short Itemproducertype { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Personglobalcode { get; set; }
    }
}
