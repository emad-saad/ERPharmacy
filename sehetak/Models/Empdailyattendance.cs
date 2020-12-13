using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empdailyattendance
    {
        public string Personcode { get; set; }
        public DateTime Transtime { get; set; }
        public string Attendbranchcode { get; set; }
        public byte Transstatus { get; set; }
        public byte Transdir { get; set; }
        public string Usercode { get; set; }
        public DateTime? UserTransTime { get; set; }
        public DateTime? TableDumped { get; set; }
        public string Empsalclosed { get; set; }
        public byte Emptransdel { get; set; }
        public string Transreasoncode { get; set; }
        public DateTime? Transtime1 { get; set; }
        public byte? Transdir1 { get; set; }
        public string Transcomment { get; set; }
    }
}
