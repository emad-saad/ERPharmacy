using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Stktransmres
    {
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public string SuppMainCode { get; set; }
        public decimal? Docnumber2 { get; set; }
        public string Comments { get; set; }
        public decimal? Docvalue { get; set; }
        public string CustBranchCode { get; set; }
        public decimal? Origintaxp { get; set; }
        public decimal? Custdiscp { get; set; }
        public decimal? Specialdiscp { get; set; }
        public string Storecode { get; set; }
        public decimal? Docvaluepay { get; set; }
        public string Fatstatuscode { get; set; }
        public string Ptcode { get; set; }
        public string Ptclassifcode { get; set; }
        public string CustBranchStore { get; set; }
        public decimal? Docvaluereturn { get; set; }
        public string Fatcurrentstatus { get; set; }
        public DateTime? Docwritedate { get; set; }
        public string CustProfessional { get; set; }
        public decimal? SalepriceExtrap { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public decimal? Patientpayment { get; set; }
        public DateTime? TableDumped { get; set; }
        public decimal? Docvalue1 { get; set; }
        public decimal? Docvalue2 { get; set; }
        public decimal? Docvalue3 { get; set; }
        public string Phcode { get; set; }
        public decimal? Personnewbal { get; set; }
        public byte? Bcurrency { get; set; }
        public decimal? Docvaluebc { get; set; }
        public decimal? Docvaluepaybc { get; set; }
        public decimal? Bcrate { get; set; }
        public string Mitemsys { get; set; }
        public string Cashiercode { get; set; }
        public byte? Origdoc { get; set; }
        public string Refdoctorcode { get; set; }
        public DateTime? Docpaydue { get; set; }
    }
}
