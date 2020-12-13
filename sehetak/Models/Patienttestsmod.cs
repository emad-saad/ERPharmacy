using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patienttestsmod
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public decimal Testprice { get; set; }
        public decimal Pttotaldue { get; set; }
        public decimal Custtotaldue { get; set; }
        public string Testrundoctor { get; set; }
        public decimal Ptpaypercent { get; set; }
        public byte Testincontract { get; set; }
        public string Valuetype { get; set; }
        public decimal Patientpayment { get; set; }
        public DateTime? TableDumped { get; set; }
        public decimal Testprice2 { get; set; }
        public decimal Pttotaldue2 { get; set; }
        public decimal Custtotaldue2 { get; set; }
        public string Testrundoctor2 { get; set; }
        public decimal Ptpaypercent2 { get; set; }
        public byte Testincontract2 { get; set; }
        public string Valuetype2 { get; set; }
        public decimal Patientpayment2 { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Modifcomment { get; set; }
    }
}
