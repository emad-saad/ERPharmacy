using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class CnIssues2
    {
        public int Issuecode { get; set; }
        public DateTime Issuedate { get; set; }
        public string Issueby { get; set; }
        public string Issueto { get; set; }
        public short Issuepriority { get; set; }
        public short Issuetype { get; set; }
        public string Issuetitle { get; set; }
        public string Issue { get; set; }
        public DateTime? Issuedelivered { get; set; }
        public DateTime? Issueclosed1 { get; set; }
        public DateTime? Issueclosed2 { get; set; }
        public DateTime? Issuered { get; set; }
        public int Issuereplycode { get; set; }
        public string Ccnames { get; set; }
        public string Cccodes { get; set; }
        public DateTime? Issuedeleted { get; set; }
    }
}
