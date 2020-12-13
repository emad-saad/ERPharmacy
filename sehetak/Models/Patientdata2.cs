using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patientdata2
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public DateTime Patientdate { get; set; }
        public string Patientname { get; set; }
        public string Patientadd1 { get; set; }
        public string Patientadd2 { get; set; }
        public string Patientphon { get; set; }
        public short? Areacode { get; set; }
        public int? Doctorcode { get; set; }
        public short Pcategorycode { get; set; }
        public string Custcode { get; set; }
        public short? Relativecode { get; set; }
        public short Paymenttype { get; set; }
        public short Paymentstatus { get; set; }
        public decimal? Patientpaypercent { get; set; }
        public decimal Pttotaldue { get; set; }
        public decimal Pttotalpay { get; set; }
        public decimal Custtotalpay { get; set; }
        public decimal Patientage { get; set; }
        public string Patientsex { get; set; }
        public decimal Totalrequired { get; set; }
        public string Ptclassifcode { get; set; }
        public decimal Custtotaldue { get; set; }
        public string Usercode { get; set; }
        public string Phcode { get; set; }
        public DateTime? TransTime { get; set; }
        public string Refdoctorcode { get; set; }
        public DateTime? Patientdobirth { get; set; }
        public DateTime? TableDumped { get; set; }
        public decimal? Custdiscp { get; set; }
        public short? Ptitle { get; set; }
        public int Labno { get; set; }
        public string RefdoctorP { get; set; }
        public string Custorigmember { get; set; }
        public string Custorigmemberid { get; set; }
        public string Patientename { get; set; }
        public string Mobileno { get; set; }
        public string Email { get; set; }
        public string HousecallCode { get; set; }
        public byte? Patientdeleted { get; set; }
        public string Ptcomments { get; set; }
        public DateTime Patientdatemotalba { get; set; }
        public byte NoJoborders { get; set; }
        public string Ptlanguage { get; set; }
        public decimal? Ptoutdue { get; set; }
        public decimal Pcategorydisc { get; set; }
        public decimal Otherdisc { get; set; }
        public decimal Ptoutduebase { get; set; }
        public string Housecall { get; set; }
        public string Custbranchcode { get; set; }
        public byte? Picip { get; set; }
        public decimal? Custpiccredit { get; set; }
        public string Hpcode { get; set; }
        public byte? Homeresult { get; set; }
        public string Vf1 { get; set; }
        public string Vf2 { get; set; }
    }
}
