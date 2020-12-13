using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class CarsItemschanges
    {
        public string Costcentercode { get; set; }
        public string Itemcode { get; set; }
        public int Dblitemflag { get; set; }
        public int Kmreading1 { get; set; }
        public int? Kmreading2 { get; set; }
        public DateTime Changedate1 { get; set; }
        public DateTime? Changedate2 { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public int? Kmreading1th { get; set; }
        public DateTime? Changedate1th { get; set; }
        public byte? Followtype { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public byte Changedel { get; set; }
    }
}
