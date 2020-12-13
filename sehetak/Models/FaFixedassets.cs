using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class FaFixedassets
    {
        public int Facode { get; set; }
        public string Faname { get; set; }
        public decimal Facost { get; set; }
        public DateTime Fabuydate { get; set; }
        public decimal Falife { get; set; }
        public string Fasuppcode { get; set; }
        public string Faclassif1 { get; set; }
        public string Faclassif2 { get; set; }
        public string Faclassif3 { get; set; }
        public decimal Fanowvalue { get; set; }
        public string Branchcode { get; set; }
        public string Locationcode { get; set; }
        public string Holdercode { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? FaEnddate { get; set; }
        public string Fastatus { get; set; }
        public string Facomments { get; set; }
        public DateTime Falastupdate { get; set; }
        public string BuyBranchcode { get; set; }
        public decimal BuyDocnumber { get; set; }
        public string SellBranchcode { get; set; }
        public decimal? SellDocnumber { get; set; }
        public byte? FaEndreason { get; set; }
        public decimal? SellFacost { get; set; }
        public decimal? SellFanowvalue { get; set; }
        public int? AddedtoFacode { get; set; }
        public decimal FacostAdded { get; set; }
        public decimal Fayearlydepp { get; set; }
        public int? Expcode { get; set; }
        public string Costcentercode { get; set; }
        public DateTime? Endwarrantydate { get; set; }
        public string Fasno { get; set; }
    }
}
