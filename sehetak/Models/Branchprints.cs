using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Branchprints
    {
        public string Branchcode { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public string Usercode { get; set; }
        public byte Joautop { get; set; }
        public byte Joitemsautop { get; set; }
        public byte Jomoney { get; set; }
        public byte Invautogen { get; set; }
        public byte Invcopies { get; set; }
        public byte Invform { get; set; }
        public byte Monreccopies { get; set; }
        public byte Monrecform { get; set; }
        public string Monrecmessagear { get; set; }
        public string Monrecmessageen { get; set; }
        public byte Resreccopies { get; set; }
        public byte Resrecform { get; set; }
        public byte Resrecmoney { get; set; }
        public string Resrecmessagear { get; set; }
        public string Resrecmessageen { get; set; }
        public byte Notyetautoprint { get; set; }
    }
}
