using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empattendspecial
    {
        public string Branchcode { get; set; }
        public DateTime Eassdate { get; set; }
        public DateTime Easfdate { get; set; }
        public byte Attendsys { get; set; }
        public string Eascomment { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public byte? Easdeleted { get; set; }
        public string Usercodedeleted { get; set; }
        public DateTime? TransTimedeleted { get; set; }
    }
}
