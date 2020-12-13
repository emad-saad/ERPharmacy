using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Secretreptypes
    {
        public short Secretreptypecode { get; set; }
        public string Secretreptypedescr { get; set; }
        public decimal Secretrepsmark { get; set; }
        public decimal Secretrepfmark { get; set; }
        public decimal HawafezF4 { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
