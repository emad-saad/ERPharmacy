using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Testfixedcomments
    {
        public int Testcode { get; set; }
        public int Commentlineno { get; set; }
        public string Linecomment { get; set; }
        public byte Linebold { get; set; }
        public byte Lineunderline { get; set; }
        public byte Lineitalic { get; set; }
        public short Linefontsize { get; set; }
        public byte Linenooftabs { get; set; }
        public byte Lineprotected { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
