using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Maintforms
    {
        public string Branchcode { get; set; }
        public byte Formno { get; set; }
        public int Formsno { get; set; }
        public short Formlineno { get; set; }
        public string Formrequest { get; set; }
        public byte RequestAccept { get; set; }
        public string Itemcode { get; set; }
        public decimal Itemqty { get; set; }
        public byte? Outmaint { get; set; }
        public short? Maintminutes { get; set; }
        public string Maintemp1 { get; set; }
        public string Maintemp2 { get; set; }
        public string Maintcomments { get; set; }
        public byte? Outmaintagent { get; set; }
        public byte? Formclosed { get; set; }
        public string Formclosedusercode { get; set; }
        public DateTime? FormclosedtransTime { get; set; }
        public byte RefFormno { get; set; }
        public int RefFormsno { get; set; }
        public short RefFormlineno { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public byte Maintupgrade { get; set; }
        public DateTime? TableDumped { get; set; }
        public decimal ItemqtyDone { get; set; }
    }
}
