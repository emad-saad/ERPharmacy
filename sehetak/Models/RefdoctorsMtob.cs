using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class RefdoctorsMtob
    {
        public int Doctorcode { get; set; }
        public string Doctorname { get; set; }
        public short Specialtycode { get; set; }
        public string Doctoradd1 { get; set; }
        public string Doctoradd2 { get; set; }
        public string Doctoradd3 { get; set; }
        public string Doctorhours { get; set; }
        public string Ptclassifcode { get; set; }
        public string Refdoctornote { get; set; }
        public short? Doctorarea { get; set; }
        public string DoctorCode1 { get; set; }
        public string Refdoctorcode { get; set; }
        public string Branchcode { get; set; }
    }
}
