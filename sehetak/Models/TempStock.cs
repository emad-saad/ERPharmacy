using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class TempStock
    {
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Branchcode { get; set; }
        public int Vyear { get; set; }
        public int Vmonth { get; set; }
        public string Vmonthdescr { get; set; }
        public string Vaccitemcode { get; set; }
        public decimal Vamount { get; set; }
        public decimal Vvalue { get; set; }
        public string Vname { get; set; }
    }
}
