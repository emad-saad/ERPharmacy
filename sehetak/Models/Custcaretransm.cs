using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Custcaretransm
    {
        public string Branchcode { get; set; }
        public int Serviceorderno { get; set; }
        public int? Refserviceorderno { get; set; }
        public DateTime Sorderstarttime { get; set; }
        public DateTime Sorderfinishtime { get; set; }
        public DateTime Sorderdate { get; set; }
        public int Sordertime { get; set; }
        public string Usercode { get; set; }
        public byte Phonetype { get; set; }
        public byte Calldirection { get; set; }
        public short Worknature { get; set; }
        public short Sorderclassif1 { get; set; }
        public short Sorderclassif2 { get; set; }
        public short Workpriority { get; set; }
        public short Workpriorityorig { get; set; }
        public byte Sorderstatus { get; set; }
        public string Soclosedusercode { get; set; }
        public DateTime? Soclosedtime { get; set; }
        public string Custcode { get; set; }
        public string Custbranchcode { get; set; }
        public string CustRepres { get; set; }
        public string Soassignedto { get; set; }
        public DateTime? Soassignedtotime { get; set; }
        public DateTime? Soassigneddue { get; set; }
        public string Newcustdescr { get; set; }
    }
}
