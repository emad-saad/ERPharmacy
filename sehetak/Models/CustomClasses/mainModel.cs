using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sehetak.Models.CustomClasses
{
    public class mainModel

    {
        public mainModel()
        {
            this.Itemsproducers = new List<SelectListItem>();
            this.itemsorigin = new List<SelectListItem>();
            this.itemsunits = new List<SelectListItem>();
            this.itemsclassif = new List<SelectListItem>();

        }

        public List<SelectListItem> Itemsproducers { get; set; }
        public List<SelectListItem> itemsorigin { get; set; }
        public List<SelectListItem> itemsunits { get; set; }
        public List<SelectListItem> itemsclassif { get; set; }
        //public List<Items> items;



        public string Itemproducername { get; set; }
        public int itemsoriginname { get; set; }
        public int itemsunitsname { get; set; }
        public int itemsclassifname { get; set; }
    }
    public class items
    {
        public items()
        {
            this.familycode = "";
            this.itemcode = "";
            this.itemname = "";
            this.unitcode ="" ;
            this.itemcostprice = 0;
            this.itemsaleprice = 0;
            this.itemcode_alt1 = "" ;
            this.itemcode_alt2 = "" ;
            this.itemcode_alt3 = "" ;
            this.itemclassifcode = "" ;
            this.itemsalestax = 0; 
            this.itemsaleprice_tax = 0;
            this.itembarcode = "" ;
            this.pharmacydiscp = 0;
            this.additionaldiscp = 0;
            this.specialdiscp = 0;
            this.itemshapecode = "";
            this.itemorigincode = "";
            this.itemeffectcode = "";
            this.suppcode = "";
            this.itemname_scientific = "";
            this.itemexpiry = "";
            this.itemcomment = "";
            this.itemsaleprice_extrap = 0;
            this.usercode = "";
            this.itemnomoreuse = "";
            this.print_barcode = "";
            this.hi_typecode = "";
            this.fmi = "";
            this.itemsaleprice2 = 0; 
            this.itemslevel = 0;           
            this.itemproducercode = "";
            this.suppitemcode = "";
            this.itemsort = 0;
            this.itemmodified = "";     
            this.packqty = 0;              
            this.unitsaleprice = 0;        
            this.fridgeitem = "";
            this.hasdifforigin = "";
            this.hasdiffpacks = "";
            this.itemtrans = "";
            this.itemsalestaxp = 0;
            this.itemmedicine = "";
            this.itemstoreclassif = "";
            this.itemupdt_monthlyqty = "";
            this.itemlastupdate = "";
            this.itemtrans1 = 0;   
            this.itemtrans2 = 0;   
            this.itemtrans3 = 0;   
            this.itemsearchkey = "";
            this.itemarchive = false;
            this.itemeffectcode2 = "";
            this.itempartno = false;
            this.itemnosaleclassif = "";
            this.itemonweb = false;
            this.itemrefcode = "";
            this.itemperformrate = false;
            this.itempointsys = false;
            this.itemexpcode = 0;
            this.costcentercode = "";
            this.itemmanuf = false;
            this.itemglobalcode = "";
            this.testcode = 0; 
            this.posdiscp = 0; 
        }
    public string familycode;          
    public string itemcode;            
    public string itemname;            
    public string unitcode;            
    public decimal itemcostprice ;     
    public decimal itemsaleprice ;     
    public string itemcode_alt1;       
    public string itemcode_alt2;       
    public string itemcode_alt3;       
    public string itemclassifcode;     
    public decimal itemsalestax ;      
    public decimal itemsaleprice_tax ; 
    public string itembarcode;         
    public decimal pharmacydiscp ;     
    public decimal additionaldiscp ;   
    public decimal specialdiscp ;      
    public string itemshapecode;       
    public string itemorigincode;      
    public string itemeffectcode;      
    public string suppcode;            
    public string itemname_scientific; 
    public string itemexpiry;          
    public string itemcomment;
    public decimal itemsaleprice_extrap;
    public string usercode;            
    public string itemnomoreuse;       
    public string print_barcode;       
    public string hi_typecode;         
    public string fmi;                 
    public decimal itemsaleprice2;     
    public short itemslevel;           
    public string itemproducercode;    
    public string suppitemcode;        
    public short itemsort;             
    public string itemmodified;        
    public short packqty;              
    public decimal unitsaleprice ;     
    public string fridgeitem;          
    public string hasdifforigin;       
    public string hasdiffpacks;        
    public string itemtrans;           
    public decimal itemsalestaxp ;     
    public string itemmedicine;        
    public string itemstoreclassif;    
    public string itemupdt_monthlyqty; 
    public string itemlastupdate;    
    public short itemtrans1;           
    public short itemtrans2;           
    public short itemtrans3;           
    public string itemsearchkey;       
    public Boolean itemarchive;           
    public string itemeffectcode2;     
    public Boolean itempartno ;           
    public string itemnosaleclassif;   
    public Boolean itemonweb ;            
    public string itemrefcode;         
    public Boolean itemperformrate ;      
    public Boolean itempointsys ;         
    public int? itemexpcode ;          
    public string costcentercode;      
    public Boolean itemmanuf ;            
    public string itemglobalcode;      
    public int testcode ;              
    public decimal posdiscp ;          

    }






}