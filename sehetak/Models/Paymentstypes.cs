using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Paymentstypes
    {
        public string Paymenttype { get; set; }
        public string Paymentdescr { get; set; }
        public decimal? PosPayweight { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
