﻿using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Personsdata1
    {
        public string Personcode { get; set; }
        public byte Ruletype { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public short Relativecode { get; set; }
        public short Testtype { get; set; }
        public short Maxnoyrly { get; set; }
        public decimal Maxvalueyrly { get; set; }
        public short Maxnoeachtime { get; set; }
        public decimal Maxvalueeachtime { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public byte Recblocked { get; set; }
        public decimal Consumedvalue { get; set; }
        public int Consumedno { get; set; }
        public string Createusercode { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
