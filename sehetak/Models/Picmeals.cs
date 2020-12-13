using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Picmeals
    {
        public string Phcode { get; set; }
        public int? Picmeal1 { get; set; }
        public int? Picmeal2 { get; set; }
        public int? Picmeal3 { get; set; }
        public string Mealcomment { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
