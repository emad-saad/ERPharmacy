using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Areas
    {
        public int Areacode { get; set; }
        public string Areaname { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public int Provincecode { get; set; }
        public string Areamanagercode { get; set; }
        public string Supervisorcode { get; set; }
        public string Repcode { get; set; }
        public decimal Areamanagerp { get; set; }
        public decimal Supervisorp { get; set; }
        public decimal Repp { get; set; }
    }
}
