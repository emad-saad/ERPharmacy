using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Tripsfiles
    {
        public string Branchcode { get; set; }
        public int Tripsno { get; set; }
        public string Fileno { get; set; }
        public byte Noofpassengers { get; set; }
        public string Fileclassif { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Tripfiledel { get; set; }
    }
}
