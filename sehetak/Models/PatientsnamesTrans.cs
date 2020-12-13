using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class PatientsnamesTrans
    {
        public string Usercode { get; set; }
        public DateTime ModifDate { get; set; }
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public string PatientnameOld { get; set; }
        public string PatientnameNew { get; set; }
        public string ModifType { get; set; }
        public DateTime? TableDumped { get; set; }
        public short? PcategorycodeOld { get; set; }
        public short? PcategorycodeNew { get; set; }
        public short? RelativecodeOld { get; set; }
        public short? RelativecodeNew { get; set; }
        public string Comments { get; set; }
        public DateTime? Patientdatemotalba1 { get; set; }
        public DateTime? Patientdatemotalba2 { get; set; }
        public decimal? Testprice11 { get; set; }
        public decimal? Testprice12 { get; set; }
        public decimal? Testprice21 { get; set; }
        public decimal? Testprice22 { get; set; }
        public string Custorigmember { get; set; }
        public string Custorigmemberid { get; set; }
        public byte? Ptpaymoney { get; set; }
        public string Custbranchcode1 { get; set; }
        public string Custbranchcode2 { get; set; }
    }
}
