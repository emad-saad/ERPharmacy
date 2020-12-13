using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Profiles
    {
        public int Profilecode { get; set; }
        public string Profilename { get; set; }
        public string ProfileNomoreuse { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Usercode { get; set; }
    }
}
