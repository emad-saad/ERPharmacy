using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Localcustomersdatesd
    {
        public string Ptcode { get; set; }
        public string Phcode { get; set; }
        public string Branchcode { get; set; }
        public int Phcodedatesno { get; set; }
        public DateTime Phcodedate { get; set; }
        public string Phcodetype { get; set; }
        public string Itemtestcode { get; set; }
        public string Itemtestdescr { get; set; }
        public string Phcodecomment { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public DateTime? TableDumped { get; set; }
        public byte Activitystatus { get; set; }
        public string Activitystatusreason { get; set; }
        public DateTime? Activitystatustime { get; set; }
        public string Activitystatususer { get; set; }
        public string Actassignedto { get; set; }
        public DateTime? Actassignedtodate { get; set; }
        public int? Refphcodedatesno { get; set; }
        public byte Activityhist { get; set; }
        public string Activityhistuser { get; set; }
        public DateTime? Activityhistdate { get; set; }
        public string Deptcode { get; set; }
        public string Phoneno { get; set; }
        public byte Actdirection { get; set; }
        public byte Actsource { get; set; }
        public string Custbranch { get; set; }
        public string CustRepres { get; set; }
        public short Sorderclassif2 { get; set; }
        public short Workpriority { get; set; }
        public short? Itemqty { get; set; }
        public string Itemunit { get; set; }
        public byte? Itemfreq { get; set; }
        public short? Noofdays { get; set; }
        public decimal? Transqty { get; set; }
        public byte? Itemroute { get; set; }
        public DateTime? Execsdate { get; set; }
        public DateTime? Execfdate { get; set; }
        public DateTime? Scheduledate { get; set; }
        public string Scheduledateuser { get; set; }
        public DateTime? Execssdate { get; set; }
        public short? Execdur1 { get; set; }
        public short? Execdur2 { get; set; }
        public string Mitemsys { get; set; }
        public decimal Execlabor { get; set; }
        public decimal Execcost { get; set; }
        public decimal Execcharge { get; set; }
        public string Vf1 { get; set; }
        public string Vf2 { get; set; }
        public decimal Collectcharge { get; set; }
        public byte Onweb { get; set; }
        public string Onwebuser { get; set; }
        public DateTime? Onwebdate { get; set; }
        public byte Activityhist2 { get; set; }
        public string Activityhist2user { get; set; }
        public DateTime? Activityhist2date { get; set; }
    }
}
