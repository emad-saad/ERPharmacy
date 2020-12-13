using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Importsm
    {
        public int Importsno { get; set; }
        public string Importdescr { get; set; }
        public DateTime Importopendate { get; set; }
        public string Suppcode { get; set; }
        public byte Bcurrency { get; set; }
        public decimal Bcrate { get; set; }
        public decimal? Orderno { get; set; }
        public decimal ImporttotValue { get; set; }
        public decimal ImporttotCargo { get; set; }
        public decimal ImporttotInsurance { get; set; }
        public decimal ImporttotCredit { get; set; }
        public decimal ImporttotTakhlis1 { get; set; }
        public decimal ImporttotTakhlis2 { get; set; }
        public decimal ImporttotTransport { get; set; }
        public decimal ImporttotOthers1 { get; set; }
        public decimal ImporttotOthers2 { get; set; }
        public byte ImportClosed { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Importcomments { get; set; }
    }
}
