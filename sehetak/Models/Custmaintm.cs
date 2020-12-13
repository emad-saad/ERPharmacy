using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Custmaintm
    {
        public string Branchcode { get; set; }
        public decimal Docnumber { get; set; }
        public int Refserviceordersno { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Planfinishdate { get; set; }
        public string Custcode { get; set; }
        public string Custname { get; set; }
        public string Custrepname { get; set; }
        public string Branchcustphone { get; set; }
        public string Branchcustaddress1 { get; set; }
        public string Branchcustaddress2 { get; set; }
        public string Phcode { get; set; }
        public string Maintserialno { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Maintreceivedby { get; set; }
        public string Maintreceiveddescr { get; set; }
        public string Maintproblems { get; set; }
        public string Maintcomments { get; set; }
        public byte Maintstatus { get; set; }
        public string Finishusercode { get; set; }
        public DateTime? Finishdate { get; set; }
        public string Maintdoneby { get; set; }
        public string Maintdonedescr { get; set; }
        public string Pphcode { get; set; }
    }
}
