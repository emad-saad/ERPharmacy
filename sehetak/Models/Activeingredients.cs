using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Activeingredients
    {
        public int Aicode { get; set; }
        public string Ainame { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Usercode { get; set; }
        public string Classcode { get; set; }
    }
}
