using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Branches
    {
        public string Branchcode { get; set; }
        public string Branchname { get; set; }
        public string Branchaddress { get; set; }
        public decimal Noofstores { get; set; }
        public decimal? Lastdocnumberin { get; set; }
        public decimal? Lastdocnumberout { get; set; }
        public string Branchphones { get; set; }
        public short? ItemsalepriceNo { get; set; }
        public string Sname { get; set; }
        public short? Exp { get; set; }
        public short? Negbal { get; set; }
        public short BsellPolicy { get; set; }
        public decimal BsellPercent { get; set; }
        public string Brelationtype { get; set; }
        public string Acciteml1 { get; set; }
        public DateTime? BranchLastupdate { get; set; }
        public string Branchdialup { get; set; }
        public string Accitemcode { get; set; }
        public string Accitemcode2 { get; set; }
        public string Accitemcode3 { get; set; }
        public DateTime? Pdate { get; set; }
        public string Branchename { get; set; }
        public string Btype { get; set; }
        public string Motalbaname { get; set; }
        public string Commercialno { get; set; }
        public string Taxfileno { get; set; }
        public string Taxcardno { get; set; }
        public string Taxdept { get; set; }
        public string Branchip { get; set; }
        public string Companycode { get; set; }
        public byte Picpoints { get; set; }
        public byte Noresultifnorevise { get; set; }
        public byte Nomodififrevised { get; set; }
        public string Resultpbranch { get; set; }
        public string Jodate { get; set; }
        public int Vf1 { get; set; }
        public int Vf2 { get; set; }
        public string Vf3 { get; set; }
        public string Vf4 { get; set; }
        public string Performbranchname { get; set; }
    }
}
