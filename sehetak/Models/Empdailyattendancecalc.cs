using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empdailyattendancecalc
    {
        public string Personcode { get; set; }
        public DateTime Attenddate { get; set; }
        public DateTime Transtime { get; set; }
        public short Attendduration { get; set; }
        public short Latetime { get; set; }
        public decimal Deductmoney { get; set; }
        public short Overtime { get; set; }
        public decimal Extramoney { get; set; }
        public decimal Deductionofdays { get; set; }
        public decimal Extraofdays { get; set; }
        public byte Emptransdel { get; set; }
        public string Branchcode { get; set; }
        public byte Deductok { get; set; }
        public string Deductusercode { get; set; }
        public DateTime? Deducttranstime { get; set; }
        public byte Extraok { get; set; }
        public string Extrausercode { get; set; }
        public DateTime? Extratranstime { get; set; }
        public string Calccomments { get; set; }
        public byte Isnightshift { get; set; }
        public byte Transdir { get; set; }
        public short Daytimecontr { get; set; }
        public short Outtime { get; set; }
        public decimal Outdeductofdays { get; set; }
        public decimal? Outdeductmoney { get; set; }
        public byte Outdeductok { get; set; }
        public string Outdeductusercode { get; set; }
        public DateTime? Outdeducttranstime { get; set; }
        public string Isoffday { get; set; }
        public byte Apply2 { get; set; }
        public byte Shiftno { get; set; }
    }
}
