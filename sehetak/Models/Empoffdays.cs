using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empoffdays
    {
        public string Empcode { get; set; }
        public DateTime Offdaysdate { get; set; }
        public DateTime Offdayfdate { get; set; }
        public DateTime TransTime { get; set; }
        public string Offdaytype { get; set; }
        public int Offdays { get; set; }
        public string Offdaycomment { get; set; }
        public byte Offdayblocked { get; set; }
        public byte? Offdayapproval { get; set; }
        public string Approveusercode { get; set; }
        public DateTime? Approvetranstime { get; set; }
        public string Approvecomment { get; set; }
    }
}
