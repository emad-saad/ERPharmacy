using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Actimages
    {
        public string Phcode { get; set; }
        public byte[] Itempicture { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public short Phcodesno { get; set; }
        public string Usercode { get; set; }
        public string Imagecomment { get; set; }
        public byte Imagetype { get; set; }
        public string Ptcode { get; set; }
        public string Branchcode { get; set; }
        public int Phcodedatesno { get; set; }
    }
}
