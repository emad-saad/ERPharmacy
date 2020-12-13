using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Imports
    {
        public int Importsno { get; set; }
        public string Itemcode { get; set; }
        public decimal Itemqty { get; set; }
        public decimal Itemqtyreal { get; set; }
        public string Unitcode { get; set; }
        public byte Bcurrency { get; set; }
        public decimal Bcrate { get; set; }
        public decimal Itemcostreal { get; set; }
        public decimal Itemcostmm { get; set; }
        public decimal Itemcustomsp { get; set; }
        public decimal Itemcustoms { get; set; }
        public decimal ItemcargoPoints { get; set; }
        public decimal Itemcargo { get; set; }
        public decimal Itemunitsalestax { get; set; }
        public decimal Iteminsurance { get; set; }
        public decimal Itemcredit { get; set; }
        public decimal Itemtakhlis1 { get; set; }
        public decimal Itemtakhlis2 { get; set; }
        public decimal Itemtransport { get; set; }
        public decimal Itemothers1 { get; set; }
        public decimal Itemothers2 { get; set; }
        public decimal Itemunitcost { get; set; }
        public decimal Itemtotcost { get; set; }
        public byte ImportClosed { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
    }
}
