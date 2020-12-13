using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Personsdata11
    {
        public string Personcode { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public short Relativecode { get; set; }
        public string Picgeneration { get; set; }
        public decimal Picpremium { get; set; }
        public int Pics { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public string Createusercode { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
