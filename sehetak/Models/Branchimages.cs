﻿using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Branchimages
    {
        public string Phcode { get; set; }
        public byte[] Itempicture { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public short Phcodesno { get; set; }
        public string Usercode { get; set; }
        public string Imagecomment { get; set; }
        public byte Imagetype { get; set; }
    }
}
