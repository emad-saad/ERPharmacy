using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Companiesitems
    {
        public string Branchcode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public string Patientname { get; set; }
        public string Patientno { get; set; }
        public string Financialno { get; set; }
        public string Fileno { get; set; }
        public string Roshettano { get; set; }
        public string Membershipno { get; set; }
        public string Deptname { get; set; }
        public string Patientnationality { get; set; }
        public string Relativedegree { get; set; }
        public string Comment { get; set; }
        public DateTime? Examdate { get; set; }
        public string HiTypecode { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Doccode { get; set; }
    }
}
