using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Offersm
    {
        public string Branchcode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Offerexpirydate { get; set; }
        public string Custcode { get; set; }
        public string Custname { get; set; }
        public decimal Docvalue { get; set; }
        public decimal Docvalue1 { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Offercomments { get; set; }
        public DateTime? Sendtocustdate { get; set; }
        public string Sendtocustusercode { get; set; }
        public DateTime? Offeragreeddate { get; set; }
        public string Offeragreedusercode { get; set; }
        public short? Offerrefusereason { get; set; }
        public DateTime? Offerrefusedate { get; set; }
        public string Offerrefuseusercode { get; set; }
        public string Offerattn { get; set; }
        public byte Bcurrency { get; set; }
    }
}
