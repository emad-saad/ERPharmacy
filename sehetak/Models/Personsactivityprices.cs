using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Personsactivityprices
    {
        public string Acttypecode { get; set; }
        public string Ptcode { get; set; }
        public string Ptclassifcode { get; set; }
        public decimal Actminvalue { get; set; }
        public int Actminvaluehrs { get; set; }
        public decimal Actextrahrvalue { get; set; }
        public decimal Actmaxvalue { get; set; }
        public byte Actpriceblock { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public string Refcontracttype { get; set; }
        public decimal NcActminvalue { get; set; }
        public int NcActminvaluehrs { get; set; }
        public decimal NcActextrahrvalue { get; set; }
        public decimal NcActmaxvalue { get; set; }
        public byte NcAllowed { get; set; }
    }
}
