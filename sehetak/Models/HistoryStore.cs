﻿using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class HistoryStore
    {
        public DateTime Timemark { get; set; }
        public string TableName { get; set; }
        public string PkDateSrc { get; set; }
        public string PkDateDest { get; set; }
        public short RecordState { get; set; }
    }
}
