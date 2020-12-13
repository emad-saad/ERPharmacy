using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class ErrorMessages
    {
        public int ErrMsgcode { get; set; }
        public string ErrMsgdescr { get; set; }
        public string ErrMsgdescren { get; set; }
        public string Dbtype { get; set; }
    }
}
