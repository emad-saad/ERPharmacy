using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Lastdocnumbers
    {
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
        public int LastpatientcodeL { get; set; }
        public int LastpatientcodeS { get; set; }
        public int LastpatientcodeC { get; set; }
        public int LastpatientcodeR { get; set; }
        public decimal Accsno { get; set; }
        public decimal Accsno2 { get; set; }
        public decimal Accsno3 { get; set; }
    }
}
