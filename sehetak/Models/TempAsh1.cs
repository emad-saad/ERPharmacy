using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class TempAsh1
    {
        public string Usercode { get; set; }
        public DateTime RefDatetime { get; set; }
        public byte RefSource { get; set; }
        public string Branchcode { get; set; }
        public int Patientcode { get; set; }
        public DateTime Reservationdate { get; set; }
        public DateTime Reservationtime { get; set; }
        public int Reservationsno { get; set; }
        public int Testcode { get; set; }
        public string Personcode { get; set; }
        public string Phcode { get; set; }
        public int Labunitcode { get; set; }
        public string Refdoctorcode { get; set; }
    }
}
