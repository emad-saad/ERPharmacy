using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class TskEmpworks
    {
        public int Worksno { get; set; }
        public int RefServiceorder { get; set; }
        public DateTime? RefReceivedate { get; set; }
        public DateTime Workdate { get; set; }
        public string Personcode { get; set; }
        public DateTime Workstime { get; set; }
        public DateTime Workftime { get; set; }
        public short Worknature { get; set; }
        public short Worklocation { get; set; }
        public short Workpriority { get; set; }
        public short Workclassif1 { get; set; }
        public short Workclassif2 { get; set; }
        public string Custcode { get; set; }
        public string Custbranchcode { get; set; }
        public short Worktype { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string CustRepres { get; set; }
        public short CustSupplies { get; set; }
        public short CustOrder { get; set; }
        public decimal CustCharges { get; set; }
        public decimal WorkOthercost { get; set; }
        public decimal WorkLaborcost { get; set; }
        public short CustContract { get; set; }
        public DateTime Startstime { get; set; }
        public decimal CustChargesCollect { get; set; }
        public short CustComplaint { get; set; }
        public short CustFeedback1 { get; set; }
        public short CustFeedback2 { get; set; }
        public short Custvisittype { get; set; }
        public decimal Worktransportcost { get; set; }
        public string Branchcode { get; set; }
    }
}
