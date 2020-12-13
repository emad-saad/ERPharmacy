using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class StkbalCheck
    {
        public int Repsno { get; set; }
        public byte Reptype { get; set; }
        public string Branchcode { get; set; }
        public string Itemcode { get; set; }
        public decimal ItemqtyStkbal { get; set; }
        public decimal ItemqtyStktrans { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public string Storecode { get; set; }
        public decimal Unitcostprice { get; set; }
        public string Repbranchcode { get; set; }
    }
}
