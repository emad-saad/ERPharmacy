using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class FaMonthlydep
    {
        public short Yearno { get; set; }
        public byte Monthno { get; set; }
        public int Facode { get; set; }
        public decimal Monthdepvalue { get; set; }
    }
}
