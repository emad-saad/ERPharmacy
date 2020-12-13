using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class ItemsReq
    {
        public string Branchcode { get; set; }
        public int Reqsno { get; set; }
        public string Itemmedicine { get; set; }
        public string ClassifCode { get; set; }
        public string Itemname { get; set; }
        public string Producername { get; set; }
        public string Suppliername { get; set; }
        public decimal Itemsaleprice { get; set; }
        public string Unitcode { get; set; }
        public short Packqty { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Reqcomment { get; set; }
        public byte Reqstatus { get; set; }
        public string StatUsercode { get; set; }
        public DateTime? StatTransTime { get; set; }
        public string Newitemcode { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
