using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Custpatientrelatives
    {
        public string Custcode { get; set; }
        public short Relativecode { get; set; }
        public decimal Patientpaypercent { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Relativecodeactive { get; set; }
    }
}
