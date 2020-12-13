using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class TempEmpslipx
    {
        public string Personname { get; set; }
        public string Ptclassifdescr { get; set; }
        public string Branchname { get; set; }
        public decimal Empsalary { get; set; }
        public decimal SumSaltimededuction { get; set; }
        public decimal SumSaltimeextra { get; set; }
        public decimal SumGiftvalue { get; set; }
        public decimal SumPenaltyvalue { get; set; }
        public decimal SumOffdays { get; set; }
        public decimal SumBorrowpayvalue { get; set; }
        public DateTime Sdate { get; set; }
        public DateTime Fdate { get; set; }
        public string Branchcode { get; set; }
        public string Personcode { get; set; }
        public decimal? EmpInsurance { get; set; }
        public decimal SumEmpbuys { get; set; }
        public decimal SumEmergency { get; set; }
        public decimal EmpCominsurance { get; set; }
        public decimal EmpEmpinsurance { get; set; }
        public decimal EmpZamala { get; set; }
        public decimal EmpEarntax { get; set; }
        public decimal EmpsalFixed { get; set; }
        public decimal EmpsalVar { get; set; }
        public decimal Emprepresent { get; set; }
        public decimal Emphousing { get; set; }
        public decimal Empextra { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public decimal? Emptimepermonth { get; set; }
        public string Ptclassifcode { get; set; }
        public short Personslevel { get; set; }
        public short Slipnop { get; set; }
        public string Slipcomment { get; set; }
        public decimal? Empyrlytaxfree { get; set; }
    }
}
