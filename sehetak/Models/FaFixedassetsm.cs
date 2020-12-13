using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class FaFixedassetsm
    {
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public string Fasuppcode { get; set; }
        public decimal Docvalue { get; set; }
        public decimal Docvaluepay { get; set; }
        public string Fatcurrentstatus { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string FaComments { get; set; }
        public decimal? Personnewbal { get; set; }
        public decimal? Docvaluereal { get; set; }
        public byte? Openassets { get; set; }
        public decimal? Origintaxp { get; set; }
        public decimal? Salestaxp { get; set; }
        public decimal? Docvalue2 { get; set; }
        public decimal? Docvalue3 { get; set; }
        public byte? Origdoc { get; set; }
        public DateTime? Docwritedate { get; set; }
        public decimal? Docnumber2 { get; set; }
    }
}
