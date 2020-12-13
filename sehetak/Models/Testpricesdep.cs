using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Testpricesdep
    {
        public int Testcode { get; set; }
        public short Pcategorycode { get; set; }
        public byte Testtype { get; set; }
        public decimal Testpricedep { get; set; }
        public string Usercode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
