using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Cheques
    {
        public int Cheqsno { get; set; }
        public string Financialdoccode { get; set; }
        public string Cheqtype { get; set; }
        public string Cheqno { get; set; }
        public DateTime Cheqdate { get; set; }
        public string Bankcode { get; set; }
        public string Personcode { get; set; }
        public decimal Cheqvalue { get; set; }
        public short? Cashtype { get; set; }
        public DateTime? Cheqcashdate { get; set; }
        public DateTime Cheqregisterdate { get; set; }
        public DateTime? Cheqtobankdate { get; set; }
        public int? Ourcheqsno { get; set; }
        public string Usercode { get; set; }
        public string Chequenote { get; set; }
        public string WenttoBankstrans { get; set; }
        public string Bankcode2 { get; set; }
        public short? RefuseReason { get; set; }
        public decimal? RefuseCharges { get; set; }
        public decimal? Cheqvaluediscount { get; set; }
        public decimal? Cheqvaluetax { get; set; }
        public decimal? Cheqvaluedamgha { get; set; }
        public DateTime? TransTime { get; set; }
        public string Branchcode { get; set; }
        public int? Payrefusesno { get; set; }
        public string Phcode { get; set; }
        public decimal Personnewbal { get; set; }
        public decimal Banknewbal { get; set; }
        public decimal Cheqcashfees { get; set; }
        public DateTime? BanktransTime { get; set; }
        public byte? OpenTrans { get; set; }
        public string Handedto { get; set; }
        public byte? Creditcardtype { get; set; }
        public byte? Ourcheqsnop { get; set; }
        public string Ptcode { get; set; }
        public byte Bcurrency { get; set; }
        public decimal Bcrate { get; set; }
        public decimal BanknewbalLc { get; set; }
        public decimal CheqvalueLc { get; set; }
        public DateTime? TableDumped { get; set; }
        public string TfBranchcode { get; set; }
        public string TfBankcode { get; set; }
        public int? TfCheqsno { get; set; }
        public decimal BcrateStd { get; set; }
        public decimal Cheqvalueother { get; set; }
        public byte? Origdoc { get; set; }
        public byte Blockinv { get; set; }
        public string Custbranchcode { get; set; }
    }
}
