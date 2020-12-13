using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Mglevels
    {
        public int Usergroup { get; set; }
        public string Mitemname { get; set; }
        public short Mitemenable { get; set; }
        public short Mitemshow { get; set; }
        public string Mitemsave { get; set; }
        public string Mitemprint { get; set; }
        public string Mitemretrieve { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Mitemscan { get; set; }
        public string Mitemdata { get; set; }
        public string Mitemmoney { get; set; }
        public string Mitemcost { get; set; }
        public string Mitemdatain { get; set; }
        public string Usercode { get; set; }
        public string Mitembrmb { get; set; }
        public string Mitemscanedit { get; set; }
        public string Mitemshortcut { get; set; }
    }
}
