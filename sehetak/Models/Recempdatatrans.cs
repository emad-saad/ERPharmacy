using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Recempdatatrans
    {
        public string Personcode { get; set; }
        public string Personname { get; set; }
        public string Ptclassifcode { get; set; }
        public DateTime? Personfdate { get; set; }
        public string Branchcode { get; set; }
        public byte Empinsurance { get; set; }
        public string Empinsuranceno { get; set; }
        public string Empsocialstatus { get; set; }
        public short Personslevel { get; set; }
        public byte EmpOwner { get; set; }
        public byte Empattendance { get; set; }
        public DateTime? Empcontractdate { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Empdatacomment { get; set; }
        public int? Expcode { get; set; }
        public string Costcentercode { get; set; }
        public string Insurebranchcode { get; set; }
        public DateTime? Empinsurancedate { get; set; }
        public string Empinwork { get; set; }
        public string Empattendtype { get; set; }
        public DateTime? Personsdate { get; set; }
        public decimal? Emptimepermonth { get; set; }
        public string Ptclassifcode40 { get; set; }
    }
}
