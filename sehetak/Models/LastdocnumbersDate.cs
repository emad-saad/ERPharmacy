using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class LastdocnumbersDate
    {
        public DateTime Refdate { get; set; }
        public string Branchcode { get; set; }
        public decimal Lastdocnumberin { get; set; }
        public decimal Lastdocnumberout { get; set; }
        public decimal Branchcustcode { get; set; }
        public decimal Paymentsno { get; set; }
        public int LocalpaymentSno { get; set; }
        public string VerBranch { get; set; }
        public decimal LastdocnumberinCust { get; set; }
        public decimal LastdocnumberoutCust { get; set; }
        public decimal LastdocnumberinSupp { get; set; }
        public decimal LastdocnumberoutSupp { get; set; }
        public decimal LastdocnumberoutInv { get; set; }
        public decimal FaLastdocnumberin { get; set; }
        public decimal FaLastdocnumberout { get; set; }
        public int FaFacode { get; set; }
    }
}
