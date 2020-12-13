using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Custdiscountstrans
    {
        public string Personcode { get; set; }
        public decimal Custdiscp { get; set; }
        public decimal Origintaxp { get; set; }
        public string Usercode { get; set; }
        public DateTime Transdate { get; set; }
        public decimal PatientPaypercent { get; set; }
        public string PatientPaytype { get; set; }
        public decimal PatientMaxfatora { get; set; }
        public string Personname { get; set; }
        public decimal? Personmaxbal { get; set; }
        public string Empftime { get; set; }
        public string Branchcode { get; set; }
        public short? Pcategorycode { get; set; }
    }
}
