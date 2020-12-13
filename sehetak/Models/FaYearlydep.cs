using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class FaYearlydep
    {
        public int Facode { get; set; }
        public short Fayear { get; set; }
        public decimal Fadepvalue { get; set; }
        public decimal Fatotvalue { get; set; }
        public decimal Fayearaddvalue { get; set; }
        public decimal Fatotdep { get; set; }
        public decimal Fadepvaluedone { get; set; }
    }
}
