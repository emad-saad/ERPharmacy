using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Testimages
    {
        public int Testcode { get; set; }
        public byte[] Itempicture { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public short Testcodesno { get; set; }
        public byte Imagetype { get; set; }
        public string Usercode { get; set; }
        public string Imagecomment { get; set; }
    }
}
