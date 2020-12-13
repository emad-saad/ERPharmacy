using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Employeesimages
    {
        public string Empcode { get; set; }
        public byte[] Emppicture { get; set; }
        public DateTime? ModifLastupdate { get; set; }
    }
}
