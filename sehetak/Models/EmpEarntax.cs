using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class EmpEarntax
    {
        public short Earnyear { get; set; }
        public short Earnmonth { get; set; }
        public string Branchcode { get; set; }
        public string Personcode { get; set; }
        public string Ptclassifdescr { get; set; }
        public string Empsocialstatus { get; set; }
        public decimal EmpsalFixed { get; set; }
        public decimal EmpsalVar { get; set; }
        public decimal Empjoballow { get; set; }
        public decimal Emprepresent { get; set; }
        public decimal Emphousing { get; set; }
        public decimal Empextra { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
