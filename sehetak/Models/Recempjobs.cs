using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Recempjobs
    {
        public string Personcode { get; set; }
        public string Ptclassifcode { get; set; }
        public string Ptclassifcode20 { get; set; }
        public string Ptclassifcode30 { get; set; }
        public string Ptclassifcode40 { get; set; }
        public string Ptclassifcode50 { get; set; }
        public string Ptclassifcode60 { get; set; }
        public short? Interviewgrade { get; set; }
        public byte? Empaccepted { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
    }
}
