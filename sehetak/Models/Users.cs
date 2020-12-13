using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Users
    {
        public string Userid { get; set; }
        public string Userpassword { get; set; }
        public string Usercode { get; set; }
        public int Usergroup { get; set; }
        public string Userentry { get; set; }
        public string UserNomore { get; set; }
        public string Userlanguage { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Mitemsys { get; set; }
        public string Branchcode { get; set; }
        public DateTime Userdate { get; set; }
        public int Userno { get; set; }
        public string Storecode { get; set; }
        public string Entryuser { get; set; }
    }
}
