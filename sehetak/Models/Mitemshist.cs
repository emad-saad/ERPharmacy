using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Mitemshist
    {
        public int Stranssno { get; set; }
        public string Mitemname { get; set; }
        public DateTime Entrydate { get; set; }
        public DateTime Applydate { get; set; }
        public byte Transclassif { get; set; }
        public byte Translevel { get; set; }
        public string Transdescr { get; set; }
        public string Transedescr { get; set; }
        public byte Transbold { get; set; }
        public byte Transunderline { get; set; }
        public byte Transfont { get; set; }
        public int Transcolor { get; set; }
    }
}
