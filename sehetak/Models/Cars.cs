using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Cars
    {
        public string Carno { get; set; }
        public string Modelcode { get; set; }
        public string Shaseeno { get; set; }
        public string Engineno { get; set; }
        public DateTime? Carlicensestartdate { get; set; }
        public DateTime? Carlicensetilldate { get; set; }
        public string Insuranceno1 { get; set; }
        public string Insuranceno2 { get; set; }
        public DateTime? Carstartdate { get; set; }
        public string Currentdrivercode { get; set; }
        public DateTime? Drivergetcardate { get; set; }
        public string Endservicecode { get; set; }
        public DateTime? Endservicedate { get; set; }
        public DateTime? Carlicenserenew { get; set; }
        public string Branchcode { get; set; }
        public string Carowntype { get; set; }
        public DateTime? Branchsdate { get; set; }
        public string Carcapacitycode { get; set; }
        public string Carstatus { get; set; }
        public string Fuelcode { get; set; }
        public short? Fuelperleter { get; set; }
        public int Carnowkm { get; set; }
        public byte? NoSale { get; set; }
        public string NoSaleDescr { get; set; }
        public byte? CarRented { get; set; }
        public string CarRentedSupp { get; set; }
        public short? Carproductionyear { get; set; }
        public byte Carmaxpassenger { get; set; }
        public string MinistryNo { get; set; }
        public DateTime? MinistryDate { get; set; }
        public int? CarFacode { get; set; }
        public int? ExpcodeExp { get; set; }
        public int? ExpcodeIncome { get; set; }
        public string Costcentercode { get; set; }
        public DateTime? Insuranceno1Date { get; set; }
        public DateTime? Insuranceno2Date { get; set; }
        public int? WarrantyKm { get; set; }
        public DateTime? WarrantyEnddate { get; set; }
        public DateTime? Purchasedate { get; set; }
        public DateTime? NoSaleEnddate { get; set; }
        public string Cartype { get; set; }
        public DateTime? Itemlastupdated { get; set; }
        public int? ExpcodeExp2 { get; set; }
        public byte Carminpassenger { get; set; }
        public string MinistryNo2 { get; set; }
        public byte? CarRentedType { get; set; }
        public string Currentdrivercode2 { get; set; }
        public DateTime? Taxfreeenddate { get; set; }
        public int? ExpcodeIncome2 { get; set; }
        public int? ExpcodeAcc { get; set; }
    }
}
