using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Stkbal
    {
        public string Storecode { get; set; }
        public string Itemcode { get; set; }
        public decimal Openqty { get; set; }
        public DateTime Opendate { get; set; }
        public decimal Opencostprice { get; set; }
        public decimal Nowqty { get; set; }
        public string Itemonshelf { get; set; }
        public decimal Onorderqty { get; set; }
        public decimal Nowcostprice { get; set; }
        public string Itemexpiry { get; set; }
        public string Usercode { get; set; }
        public decimal Monthlyqty { get; set; }
        public string Branchcode { get; set; }
        public decimal Maxnowqty { get; set; }
        public DateTime? TransTime { get; set; }
        public string UsercodeMq { get; set; }
        public DateTime? TransTimeMq { get; set; }
        public string UsercodeXq { get; set; }
        public DateTime? TransTimeXq { get; set; }
        public decimal Nowqtyout { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Opentrans { get; set; }
        public decimal Nowqtyhq { get; set; }
        public decimal? Rcostprice { get; set; }
        public decimal? Onorderqtymonths { get; set; }
        public decimal? Maxnowqtymonths { get; set; }
        public DateTime? IvmTime { get; set; }
    }
}
