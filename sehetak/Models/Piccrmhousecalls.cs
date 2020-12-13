using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Piccrmhousecalls
    {
        public string Branchcode { get; set; }
        public string Custphcode { get; set; }
        public decimal Crmhcorderno { get; set; }
        public short Crmhcorderflag { get; set; }
        public int Testcode { get; set; }
        public int Profilecode { get; set; }
        public short Testdaysforresults { get; set; }
        public decimal Testprice { get; set; }
        public decimal Ptpaypercent { get; set; }
        public byte Testincontract { get; set; }
        public decimal Testpricebase { get; set; }
        public string Valuetype { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Obranchcode { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
