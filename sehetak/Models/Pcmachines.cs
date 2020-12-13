using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Pcmachines
    {
        public string Machinecode { get; set; }
        public string Machinedescr { get; set; }
        public short? Labunitcode { get; set; }
        public string Machineip { get; set; }
        public string Machinename { get; set; }
        public string Machinedomain { get; set; }
        public int? Sortorder { get; set; }
        public string PrinterA4 { get; set; }
        public string PrinterReceipt { get; set; }
        public string PrinterBarcode { get; set; }
    }
}
