using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empoffdaystrans
    {
        public string Personcode { get; set; }
        public DateTime Transdate { get; set; }
        public decimal Empoldoffdays { get; set; }
        public decimal Empyrlyoffdays { get; set; }
        public decimal Empremainoffdays { get; set; }
        public string Offdayscomment { get; set; }
        public byte RecSource { get; set; }
        public byte Empoldarda { get; set; }
        public byte Empyrlyarda { get; set; }
        public byte Empremainarda { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public byte Empoldsick { get; set; }
        public byte Empyrlysick { get; set; }
        public byte Empremainsick { get; set; }
        public byte? Empoldrr { get; set; }
        public byte? Empyrlyrr { get; set; }
        public byte? Empremainrr { get; set; }
    }
}
