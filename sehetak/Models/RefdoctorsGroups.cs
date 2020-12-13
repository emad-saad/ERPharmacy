using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class RefdoctorsGroups
    {
        public string Refdoctorcode { get; set; }
        public int Usergroup { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
