using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class Resultsrevisingdocs
    {
        public string Branchcode { get; set; }
        public string Personcode { get; set; }
        public DateTime? ModifLastupdate { get; set; }
        public string Performdoc { get; set; }
        public string Revisedoc { get; set; }
        public decimal Revdocpercent { get; set; }
        public short Labunitcode { get; set; }
    }
}
