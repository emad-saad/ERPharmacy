using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Localcustomers2
    {
        public string Phcode { get; set; }
        public string Sourcepic { get; set; }
        public short? Sourcepicpoints { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
        public DateTime? Mgmdate { get; set; }
    }
}
