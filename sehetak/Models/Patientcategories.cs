using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientcategories
    {
        public short Pcategorycode { get; set; }
        public string Pcategoryname { get; set; }
        public string Pcategorytype { get; set; }
        public string CatNomoreuse { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public byte? Pcatpricelist { get; set; }
        public short? BasePcategorycode { get; set; }
        public decimal? BaseDiscount { get; set; }
        public string Defcat { get; set; }
        public byte? Smplout { get; set; }
        public string Vf1 { get; set; }
        public string Vf2 { get; set; }
        public byte Isalp { get; set; }
        public byte Invoicep { get; set; }
        public byte Recisalp { get; set; }
        public string Vf3 { get; set; }
        public string Vf4 { get; set; }
    }
}
