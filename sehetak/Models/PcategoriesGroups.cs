using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class PcategoriesGroups
    {
        public short Pcategorycode { get; set; }
        public int Usergroup { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Usercode { get; set; }
        public byte Pcgblock { get; set; }
    }
}
