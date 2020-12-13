using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Hcitrans
    {
        public string Softechprovidercode { get; set; }
        public string Softechproviderbranch { get; set; }
        public string Softechcustcode { get; set; }
        public string Phcode { get; set; }
        public short Relativecode { get; set; }
        public DateTime Transdate { get; set; }
        public DateTime Transdatetime { get; set; }
        public byte Testtype { get; set; }
        public string Pitemtestcode { get; set; }
        public string Pitemtestdescr { get; set; }
        public byte Testincontract { get; set; }
        public string Citemtestcode { get; set; }
        public string Citemtestdescr { get; set; }
        public decimal Itemqty { get; set; }
        public decimal Itemunitprice { get; set; }
        public decimal Ptotalrequired { get; set; }
        public decimal Ppttotaldue { get; set; }
        public decimal Ptpaypercent { get; set; }
        public int Approvalsno { get; set; }
        public decimal Approvalqty { get; set; }
        public string Approvalusercode { get; set; }
        public DateTime Approvaldatetime { get; set; }
        public DateTime? TableDumped { get; set; }
        public byte Approvaltype { get; set; }
        public decimal Citemunitprice { get; set; }
        public decimal Ctotalrequired { get; set; }
        public decimal Cpttotaldue { get; set; }
        public byte Transblock { get; set; }
        public string Transblockusercode { get; set; }
        public DateTime? Transblocktime { get; set; }
        public int? Spdnno { get; set; }
        public DateTime? Spdndate { get; set; }
        public byte? Isrefund { get; set; }
        public short? Itemdose { get; set; }
        public byte? Itemfreq { get; set; }
        public short? Itemdays { get; set; }
        public DateTime? Capprovaldate { get; set; }
        public DateTime? Capprovalfdate { get; set; }
        public decimal? Cptpaypercent { get; set; }
        public byte? Appreason { get; set; }
        public int? Claimsno { get; set; }
        public decimal Apptotalrequired { get; set; }
        public decimal Itemsaleprice { get; set; }
        public string Spdnappreason { get; set; }
        public string Usercode { get; set; }
    }
}
