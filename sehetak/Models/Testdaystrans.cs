﻿using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Testdaystrans
    {
        public int Testcode { get; set; }
        public short Dayno { get; set; }
        public string Lasttime { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public string TestdayNomoreuse { get; set; }
        public string Branchcode { get; set; }
        public string Usercode { get; set; }
    }
}
