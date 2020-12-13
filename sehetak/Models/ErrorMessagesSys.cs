using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class ErrorMessagesSys
    {
        public string Dbtype { get; set; }
        public int ErrMsgcode { get; set; }
        public string ErrMsgtext { get; set; }
        public DateTime ErrMsgtime { get; set; }
        public string Mitemname { get; set; }
        public string Usercode { get; set; }
    }
}
