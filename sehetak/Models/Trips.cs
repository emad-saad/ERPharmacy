using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Trips
    {
        public int Tripsno { get; set; }
        public string Carno { get; set; }
        public string Branchcode { get; set; }
        public string CarBranchcode { get; set; }
        public string Drivercode { get; set; }
        public DateTime Tripdate { get; set; }
        public string Custcode { get; set; }
        public int Triporderno { get; set; }
        public short Tripcode { get; set; }
        public short Noofpassengers { get; set; }
        public string Voucher { get; set; }
        public int? Kmreading1 { get; set; }
        public int? Kmreading2 { get; set; }
        public int? Kmdistance { get; set; }
        public DateTime? Tripstime { get; set; }
        public DateTime? Tripftime { get; set; }
        public short? Triptime { get; set; }
        public short? Triptimemin { get; set; }
        public byte Tripdone { get; set; }
        public DateTime? TripdateReal { get; set; }
        public short Tripprinted { get; set; }
        public decimal Drivergift { get; set; }
        public decimal Docnumber { get; set; }
        public string TripCarcapacitycode { get; set; }
        public decimal TripPrice { get; set; }
        public byte TripBcurrency { get; set; }
        public string Usercode { get; set; }
        public DateTime? TransTime { get; set; }
        public string DocnumberUsercode { get; set; }
        public DateTime? DocnumberTransTime { get; set; }
        public string Drivercode2 { get; set; }
        public decimal Drivergift2 { get; set; }
        public byte Tripnoshow { get; set; }
        public string Tripstartfrom { get; set; }
        public string Tripcomments { get; set; }
        public decimal Custdiscp { get; set; }
        public string CustdiscpUsercode { get; set; }
        public decimal CarrentCost { get; set; }
        public byte Carrented { get; set; }
        public decimal Bcrate { get; set; }
        public byte? Carrentedtype { get; set; }
        public DateTime? TableDumped { get; set; }
        public decimal Tripspecialprice { get; set; }
        public string RentCarcapacitycode { get; set; }
        public decimal Suppdiscp { get; set; }
        public string SuppdiscpUsercode { get; set; }
        public DateTime? DocnumberDocdate { get; set; }
        public decimal Tripsalestaxp { get; set; }
        public decimal Cartacost { get; set; }
    }
}
