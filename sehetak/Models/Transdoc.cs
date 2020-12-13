using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Transdoc
    {
        public string Doccode { get; set; }
        public string Docdescr { get; set; }
        public byte? Docallow { get; set; }
        public short? Docorder { get; set; }
    }
}
