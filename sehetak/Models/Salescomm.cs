using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Salescomm
    {
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public byte Salescommno { get; set; }
        public string Personcode { get; set; }
        public decimal Salespercent { get; set; }
        public byte Percentcancel { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
        public int? Areacode { get; set; }
        public string Reptype { get; set; }
    }
}
