using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Softechreports
    {
        public string Vsoftechcustcode { get; set; }
        public string Branchcode { get; set; }
        public int Custreportsno { get; set; }
        public string Mitemname { get; set; }
        public byte Mitemclassif { get; set; }
        public string Mitemcomment { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
        public DateTime? DataTransferred { get; set; }
        public string Custreportedby { get; set; }
        public DateTime Custreporteddate { get; set; }
        public byte Executestatuscode { get; set; }
        public DateTime? Expectedfinishdate { get; set; }
        public DateTime? Realfinishdate { get; set; }
        public string Vsoftechcustname { get; set; }
    }
}
