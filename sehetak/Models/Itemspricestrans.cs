using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Itemspricestrans
    {
        public DateTime Transdate { get; set; }
        public decimal ItemsalepriceP { get; set; }
        public string Itemorigincode { get; set; }
        public string Usercode { get; set; }
        public string Transnote { get; set; }
        public string Suppcode { get; set; }
        public string Itemname { get; set; }
    }
}
