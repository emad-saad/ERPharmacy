using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class AccitemsDate
    {
        public DateTime Refdate { get; set; }
        public string Accitemcode { get; set; }
        public decimal Accdebit { get; set; }
        public decimal Acccredit { get; set; }
    }
}
