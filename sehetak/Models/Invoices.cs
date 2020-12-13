using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Invoices
    {
        public string Branchcode { get; set; }
        public int Invoiceserialno { get; set; }
        public int Patientcode { get; set; }
        public DateTime? Invoicedate { get; set; }
        public string Usercode { get; set; }
        public DateTime? TableDumped { get; set; }
        public byte Patientdeleted { get; set; }
        public int Noofprints { get; set; }
        public decimal Invoicevalue { get; set; }
        public string Phcode { get; set; }
        public DateTime TransTime { get; set; }
        public decimal? Invoicedisc { get; set; }
        public byte? Picip { get; set; }
    }
}
