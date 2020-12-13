using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class BasicData
    {
        public int Bdatasno { get; set; }
        public string Bdatacode { get; set; }
        public string Bdataname { get; set; }
        public string Bdatanamearabic { get; set; }
        public string Bdataclassif { get; set; }
        public DateTime? BdataLastupdate { get; set; }
        public string BdataHelp { get; set; }
        public decimal? BdataValue { get; set; }
        public string Usercode { get; set; }
        public int? BdataLong { get; set; }
        public int? BdataInt1 { get; set; }
        public int? BdataInt2 { get; set; }
        public decimal? BdataValue2 { get; set; }
        public string BdataVchar1 { get; set; }
        public string BdataVchar2 { get; set; }
        public string BdataVchar3 { get; set; }
        public byte? Bdblock { get; set; }
    }
}
