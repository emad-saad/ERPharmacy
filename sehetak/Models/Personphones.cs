using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Personphones
    {
        public string Ptcode { get; set; }
        public string Personcode { get; set; }
        public string Phoneno { get; set; }
        public string Phonenonote { get; set; }
        public string Phonetype { get; set; }
        public string Stckorderallow { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public DateTime? TableDumped { get; set; }
        public byte Phoneblock { get; set; }
    }
}
