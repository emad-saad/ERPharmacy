using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class CcarsTripsinplan
    {
        public string Branchcode { get; set; }
        public DateTime Tripdate { get; set; }
        public int Tripsno { get; set; }
        public short Tripcode { get; set; }
        public DateTime Tripstime { get; set; }
        public DateTime Tripftime { get; set; }
        public short Noofpassengers { get; set; }
        public string Custcode { get; set; }
        public int Pdtripsno { get; set; }
        public string Serviceorderno { get; set; }
        public decimal Tripprice { get; set; }
        public string Carnobylaw { get; set; }
        public string Usercodebylaw { get; set; }
        public DateTime Tripactdate { get; set; }
        public DateTime Tripdate2 { get; set; }
        public DateTime? Tripacttime1 { get; set; }
        public DateTime? Tripacttime2 { get; set; }
        public byte? Tripnoshow { get; set; }
        public string Carnoactual { get; set; }
        public string Tripstartfrom { get; set; }
        public string Triprepres { get; set; }
        public decimal Tripspecialprice { get; set; }
        public string CustCarcapacitycode { get; set; }
        public string SuppCarcapacitycode { get; set; }
        public byte CarRented { get; set; }
        public decimal Carrentprice { get; set; }
        public string Dayclosed { get; set; }
    }
}
