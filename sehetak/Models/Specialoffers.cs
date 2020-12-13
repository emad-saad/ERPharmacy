using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Specialoffers
    {
        public string Branchcode { get; set; }
        public DateTime SpecialofferStartdate { get; set; }
        public DateTime SpecialofferFinishdate { get; set; }
        public short Specialoffertype { get; set; }
        public string SpecialofferItemcode { get; set; }
        public decimal ItemqtyFrom { get; set; }
        public decimal ItemqtyTo { get; set; }
        public string BonusItemcode { get; set; }
        public decimal BonusItemqty { get; set; }
        public string OfferByPercent { get; set; }
        public int Offersno { get; set; }
        public string Classifcode { get; set; }
        public DateTime? OfferLastupdate { get; set; }
        public string Storecode { get; set; }
        public string Producercode { get; set; }
    }
}
