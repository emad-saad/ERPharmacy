using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Accitems
    {
        public string Accitemcode { get; set; }
        public string Accitemname { get; set; }
        public string Acciteml1 { get; set; }
        public string Acciteml2 { get; set; }
        public string Acciteml3 { get; set; }
        public string Acciteml4 { get; set; }
        public string Acciteml5 { get; set; }
        public string Acciteml6 { get; set; }
        public short Acclast { get; set; }
        public short Accfinalcode { get; set; }
        public decimal Accdebit { get; set; }
        public decimal Acccredit { get; set; }
        public short Accnature { get; set; }
        public decimal Accdebitopen { get; set; }
        public decimal Acccreditopen { get; set; }
        public string Accsystem { get; set; }
        public decimal? Accdebittemp { get; set; }
        public decimal? Acccredittemp { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public byte? Accitembud { get; set; }
        public byte? Accitemfs { get; set; }
        public byte? Accitemis { get; set; }
    }
}
