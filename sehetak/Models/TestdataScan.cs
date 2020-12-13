using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class TestdataScan
    {
        public int Testcode { get; set; }
        public string Testname { get; set; }
        public short Labunitcode { get; set; }
        public short Daysforresults { get; set; }
        public int? Sortinggroup { get; set; }
        public decimal? Testcostprice { get; set; }
        public string Testonweb { get; set; }
        public string Itemcode { get; set; }
        public int? ExpcodeIncome { get; set; }
        public string Costcentercode { get; set; }
        public byte? Testpricelist { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public byte? Testtype { get; set; }
        public short Performlabunitcode { get; set; }
    }
}
