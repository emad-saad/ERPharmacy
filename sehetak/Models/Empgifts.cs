using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empgifts
    {
        public string Personcode { get; set; }
        public DateTime Actiondate { get; set; }
        public decimal Giftvalue { get; set; }
        public decimal Penaltyvalue { get; set; }
        public string Actionnote { get; set; }
        public decimal Giftdays { get; set; }
        public decimal Penaltydays { get; set; }
        public decimal Empsalperday { get; set; }
        public int? Penaltycode { get; set; }
        public byte Giftattendance { get; set; }
        public short Actionsno { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public short Penaltyno { get; set; }
        public string Appliedbycode { get; set; }
        public byte Transtype { get; set; }
        public byte Effectstatus { get; set; }
        public string Effectuser { get; set; }
        public DateTime? Effectdate { get; set; }
        public decimal Effectvalue { get; set; }
    }
}
