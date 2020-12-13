using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empdailyattendancesum
    {
        public int Attendyear { get; set; }
        public byte Attendmonth { get; set; }
        public string Personcode { get; set; }
        public string Ptclassifcode { get; set; }
        public string Empattendtype { get; set; }
        public decimal Empdeduction { get; set; }
        public decimal Empextra { get; set; }
        public string Usercode { get; set; }
        public decimal LatetimeReal { get; set; }
        public decimal LatetimeWeighted { get; set; }
        public decimal OvertimeReal { get; set; }
        public decimal OvertimeWeighted { get; set; }
    }
}
