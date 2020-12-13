using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Refdoctorsschedule
    {
        public string Branchcode { get; set; }
        public string Refdoctorcode { get; set; }
        public byte Dayno { get; set; }
        public DateTime Empstime { get; set; }
        public DateTime Empftime { get; set; }
        public short Labunitcode { get; set; }
        public byte Schedulelock { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Usercode { get; set; }
        public short? Daymaxpatients { get; set; }
    }
}
