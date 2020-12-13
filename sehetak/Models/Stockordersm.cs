using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Stockordersm
    {
        public string Branchcode { get; set; }
        public decimal Docnumber { get; set; }
        public DateTime Docdate { get; set; }
        public string Suppcode { get; set; }
        public DateTime? Docgetdate { get; set; }
        public decimal Docvalue { get; set; }
        public short? Docstatuscode { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public string Comments { get; set; }
        public string Ordertoname { get; set; }
        public decimal Origintaxp { get; set; }
        public string Forbranchcode { get; set; }
        public string Tobranchcode { get; set; }
        public string Statususercode { get; set; }
        public DateTime? StatustransTime { get; set; }
        public byte Poclassif { get; set; }
        public DateTime? Powarningdate { get; set; }
        public byte Poclosed { get; set; }
        public DateTime? TableDumped { get; set; }
        public byte Purapp { get; set; }
        public string Purusercode { get; set; }
        public DateTime? PurtransTime { get; set; }
        public string Storecode { get; set; }
        public byte Whapp { get; set; }
        public string Whusercode { get; set; }
        public DateTime? WhtransTime { get; set; }
    }
}
