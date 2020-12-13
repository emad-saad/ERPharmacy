using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Picstrans
    {
        public string Branchcode { get; set; }
        public string Phcode { get; set; }
        public string Pphcode { get; set; }
        public string Phcode2 { get; set; }
        public string Pphcode2 { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
        public byte Picip { get; set; }
        public string Phcodestatus { get; set; }
        public byte Picpoints { get; set; }
        public byte Picdiscounts { get; set; }
        public byte Picpurchase { get; set; }
        public DateTime? Picpurchasedate { get; set; }
        public byte Piclock { get; set; }
        public string Piclockname { get; set; }
        public short? Pcategorycode { get; set; }
        public string Custcode { get; set; }
        public short? Relativecode { get; set; }
        public string Custorigmember { get; set; }
        public string Custorigmemberid { get; set; }
        public string Custbranchcode { get; set; }
        public decimal Custpiccredit { get; set; }
    }
}
