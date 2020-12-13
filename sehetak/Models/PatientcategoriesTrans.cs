using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class PatientcategoriesTrans
    {
        public short Pcategorycode { get; set; }
        public DateTime TransTime { get; set; }
        public string Usercode { get; set; }
        public short? BasePcategorycode { get; set; }
        public decimal BaseDiscount { get; set; }
    }
}
