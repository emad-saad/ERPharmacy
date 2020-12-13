using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patienttests2
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public decimal Testprice { get; set; }
        public DateTime? Testrundate { get; set; }
        public DateTime? Testresultdate { get; set; }
        public int Profilecode { get; set; }
        public short? PatienttestOrder { get; set; }
        public short? ResultwrittenFlag { get; set; }
        public DateTime? Testsampledate { get; set; }
        public string Phcode { get; set; }
        public string Performbranchcode { get; set; }
        public DateTime? TableDumped { get; set; }
        public string ReviseDoctorcode { get; set; }
        public DateTime? ReviseTransTime { get; set; }
        public byte Patientdeleted { get; set; }
        public decimal Ptpaypercent { get; set; }
        public byte Testincontract { get; set; }
        public byte Ptestdelivery { get; set; }
        public byte Btestdelivery { get; set; }
        public byte Testresultform { get; set; }
        public DateTime Testtopatientdate { get; set; }
        public byte Testsample { get; set; }
        public byte Testout { get; set; }
        public DateTime? Testruntime { get; set; }
        public string Testrundoctor { get; set; }
        public string Revise2Doctorcode { get; set; }
        public DateTime? Revise2TransTime { get; set; }
        public byte Joborder { get; set; }
        public int PatientcodeRec { get; set; }
        public decimal? Testpricebase { get; set; }
        public string Valuetype { get; set; }
        public byte Transqtyp { get; set; }
        public byte Transqtyu { get; set; }
        public decimal Rundoctordeal { get; set; }
        public string Testcomment { get; set; }
        public decimal Rundoctorbonus { get; set; }
        public decimal Rundoctortax { get; set; }
        public decimal Testpriceout { get; set; }
        public decimal Patientpayment { get; set; }
        public byte? Joborderno { get; set; }
        public string Vf1 { get; set; }
        public string Vf2 { get; set; }
    }
}
