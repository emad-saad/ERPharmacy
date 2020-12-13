using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Motalbas
    {
        public string Personcode { get; set; }
        public int Motalbano { get; set; }
        public DateTime Motalbadate { get; set; }
        public string Personbranchcode { get; set; }
        public DateTime Motfromdate { get; set; }
        public DateTime Mottodate { get; set; }
        public DateTime Motissuedate { get; set; }
        public int Motnumber { get; set; }
        public short Motnoofpages { get; set; }
        public short Motnoofpatients { get; set; }
        public decimal Docvaluetotal { get; set; }
        public decimal Docvaluenet { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public byte Motalbadel { get; set; }
        public string Motalbacomment { get; set; }
        public decimal Mottotsupp { get; set; }
        public decimal Mottotcontract { get; set; }
        public decimal Mottotapproved { get; set; }
        public string Motapproveby { get; set; }
        public DateTime? Motapprovedate { get; set; }
        public decimal Mottotcust { get; set; }
        public decimal Mottotpatient { get; set; }
    }
}
