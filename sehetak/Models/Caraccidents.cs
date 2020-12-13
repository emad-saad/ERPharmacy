using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Caraccidents
    {
        public string Branchcode { get; set; }
        public int AccidentSno { get; set; }
        public short AccidentUpgrade { get; set; }
        public string Carno { get; set; }
        public int Kmreading { get; set; }
        public DateTime Accidentdate { get; set; }
        public string Drivercode { get; set; }
        public string Accidentplace { get; set; }
        public int Accidentarea { get; set; }
        public string Accidenttime { get; set; }
        public string Accidentclassifcode { get; set; }
        public string Accidentreasoncode { get; set; }
        public string Accidentdescr { get; set; }
        public string Accidentdamages { get; set; }
        public string Suppcode { get; set; }
        public DateTime? Maintstartdate { get; set; }
        public DateTime? Maintenddate { get; set; }
        public int? Maintduration { get; set; }
        public decimal? Accidentcost { get; set; }
        public decimal? Accidentcompensation { get; set; }
        public byte? Chequeto { get; set; }
        public string Chequeno { get; set; }
        public DateTime? Chequedate { get; set; }
        public DateTime? ChequedateRec { get; set; }
        public string Insurancecompanyno { get; set; }
        public DateTime? TransTime { get; set; }
        public string Usercode { get; set; }
    }
}
