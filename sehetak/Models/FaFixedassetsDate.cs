using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class FaFixedassetsDate
    {
        public DateTime Refdate { get; set; }
        public int Facode { get; set; }
        public decimal Facost { get; set; }
        public decimal Fanowvalue { get; set; }
        public decimal FacostAdded { get; set; }
    }
}
