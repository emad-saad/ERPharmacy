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

        public string Itemproducername { get; set; }
        public int itemsoriginname { get; set; }
        public int itemsunitsname { get; set; }
        public int itemsclassifname { get; set; }
    }
}