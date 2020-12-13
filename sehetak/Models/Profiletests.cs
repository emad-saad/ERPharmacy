using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Profiletests
    {
        public int Profilecode { get; set; }
        public int Testcode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string ProfiletestNomoreuse { get; set; }
        public string Itemcode { get; set; }
        public byte Transqtyp { get; set; }
        public byte Transqtyu { get; set; }
    }
}
