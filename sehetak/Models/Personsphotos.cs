﻿using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Personsphotos
    {
        public string Phcode { get; set; }
        public string Ptcode { get; set; }
        public short Phcodesno { get; set; }
        public byte[] Itempicture { get; set; }
        public string Usercode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Imagecomment { get; set; }
    }
}
