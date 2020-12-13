using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Empsalaries
    {
        public string Personcode { get; set; }
        public DateTime Salarydate { get; set; }
        public decimal Salary { get; set; }
        public string Salarycomment { get; set; }
        public decimal Salarydiff { get; set; }
        public decimal EmpsalFixed { get; set; }
        public decimal EmpsalVar { get; set; }
        public decimal Empjoballow { get; set; }
        public decimal Emprepresent { get; set; }
        public decimal Emphousing { get; set; }
        public decimal Empextra { get; set; }
        public decimal EmpsalSpecial { get; set; }
        public byte EmpinsuranceInjury { get; set; }
        public decimal Origintaxp { get; set; }
        public string Usercode { get; set; }
        public DateTime TransTime { get; set; }
        public string Realsalmodif { get; set; }
        public byte Pausesalary { get; set; }
        public decimal Empsal08 { get; set; }
        public decimal Empsal09 { get; set; }
        public byte Taxsal01 { get; set; }
        public byte Taxsal02 { get; set; }
        public byte Taxsal03 { get; set; }
        public byte Taxsal04 { get; set; }
        public byte Taxsal05 { get; set; }
        public byte Taxsal06 { get; set; }
        public byte Taxsal07 { get; set; }
        public byte Taxsal08 { get; set; }
        public byte Taxsal09 { get; set; }
        public byte? Origintaxtype { get; set; }
    }
}
