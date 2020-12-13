using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Maintformsm
    {
        public string Branchcode { get; set; }
        public byte Formno { get; set; }
        public int Formsno { get; set; }
        public DateTime Formdate { get; set; }
        public string Carno { get; set; }
        public int Carkm { get; set; }
        public string Drivercode { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Managercode { get; set; }
        public byte? RefFormno { get; set; }
        public int? RefFormsno { get; set; }
        public short? Noofprints { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
