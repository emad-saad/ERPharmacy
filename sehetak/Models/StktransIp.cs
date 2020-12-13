using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class StktransIp
    {
        public string Branchcode { get; set; }
        public string Doccode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public string Itemcode { get; set; }
        public short Dblitemflag { get; set; }
        public string Brancode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public string Phcode { get; set; }
        public byte Itemqtyp { get; set; }
        public byte Itemqtyu { get; set; }
        public DateTime TransTime { get; set; }
        public byte Isnew { get; set; }
    }
}
