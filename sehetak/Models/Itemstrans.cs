using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Itemstrans
    {
        public string Itemcode { get; set; }
        public string Itembarcode { get; set; }
        public decimal Itemsaleprice { get; set; }
        public decimal ItemsalepriceExtrap { get; set; }
        public decimal Itemsalestax { get; set; }
        public decimal ItemsalepriceTax { get; set; }
        public decimal Pharmacydiscp { get; set; }
        public decimal Additionaldiscp { get; set; }
        public decimal Specialdiscp { get; set; }
        public decimal Itemcostprice { get; set; }
        public DateTime Transdate { get; set; }
        public string Usercode { get; set; }
        public string PrintBarcode { get; set; }
        public string Transnote { get; set; }
        public decimal Itemsaleprice2 { get; set; }
        public short Packqty { get; set; }
        public decimal Unitsaleprice { get; set; }
        public string Itemname { get; set; }
        public string Itemtrans { get; set; }
        public decimal Itemsalestaxp { get; set; }
        public string Itemexpiry { get; set; }
        public string Itemnomoreuse { get; set; }
        public short? Itemtrans1 { get; set; }
        public short? Itemtrans2 { get; set; }
        public short? Itemtrans3 { get; set; }
        public byte? Itemarchive { get; set; }
        public byte? Itemslevel { get; set; }
        public byte? Itemonweb { get; set; }
        public byte? Itemperformrate { get; set; }
        public byte? Itempointsys { get; set; }
        public byte? Pricechange { get; set; }
        public int Transsno { get; set; }
        public string Itemproducercode { get; set; }
        public string Suppcode { get; set; }
        public string Itemmedicine { get; set; }
        public string Familycode { get; set; }
        public string Itemclassifcode { get; set; }
        public string Itemshapecode { get; set; }
        public string Itemorigincode { get; set; }
        public string Itemeffectcode { get; set; }
        public string Itemeffectcode2 { get; set; }
        public string ItemcodeAlt3 { get; set; }
        public string Itemnosaleclassif { get; set; }
        public string Itemnew { get; set; }
    }
}
