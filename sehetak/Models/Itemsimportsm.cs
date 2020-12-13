using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Itemsimportsm
    {
        public string Branchcode { get; set; }
        public int Importsno { get; set; }
        public string Storecode { get; set; }
        public string Importdescr { get; set; }
        public string Costcentercode { get; set; }
        public string Suppcode { get; set; }
        public byte Bcurrency { get; set; }
        public decimal Bcrate { get; set; }
        public decimal Suppdocvaluebc { get; set; }
        public decimal Suppdocvaluelc { get; set; }
        public DateTime Itemsreceivedate { get; set; }
        public DateTime Importopendate { get; set; }
        public decimal? Orderno { get; set; }
        public decimal ImporttotSalestax { get; set; }
        public decimal ImporttotOrigintax { get; set; }
        public decimal ImporttotExpenses { get; set; }
        public decimal ImportBcfactor { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Importcomments { get; set; }
        public byte? Origdoc { get; set; }
    }
}
