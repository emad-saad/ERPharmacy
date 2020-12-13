using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Customerbranches
    {
        public string Custcode { get; set; }
        public string Custbranchcode { get; set; }
        public string Custbranchname { get; set; }
        public DateTime? ModifyLastupdate { get; set; }
        public DateTime Branchstartdate { get; set; }
        public string Branchclassif { get; set; }
        public string Branchblocked { get; set; }
        public string Usercode { get; set; }
        public DateTime? Contractstartdate { get; set; }
        public DateTime? Contractenddate { get; set; }
        public decimal? Monthlyfees { get; set; }
        public string Custbrglobalcode { get; set; }
        public string Brphone { get; set; }
        public int? Areacode { get; set; }
        public string Braddress { get; set; }
        public DateTime? Branchexpirydate { get; set; }
    }
}
