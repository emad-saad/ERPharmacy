using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empcomments
    {
        public string Personcode { get; set; }
        public DateTime Commentdate { get; set; }
        public string Comment { get; set; }
        public string Whowrotethis { get; set; }
        public decimal? Secretrepmark { get; set; }
        public short? Secretreptypecode { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
    }
}
