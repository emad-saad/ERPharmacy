using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Patienttestsitems
    {
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public int Testcode { get; set; }
        public string Itemcode { get; set; }
        public decimal Itemqtystd { get; set; }
        public decimal Itemqty { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public byte Samplecon { get; set; }
        public DateTime? TableDumped { get; set; }
        public byte Uniqueconsumable { get; set; }
        public string Performbranchcode { get; set; }
        public byte Uniqueuconsumable { get; set; }
    }
}
