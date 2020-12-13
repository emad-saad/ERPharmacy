using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class ShPicPrefrences
    {
        public string Phcode { get; set; }
        public byte AlertsEnable { get; set; }
        public byte AlertsMobile { get; set; }
        public byte AlertsPhone { get; set; }
        public byte AlertsEmail { get; set; }
        public byte AlertsSms { get; set; }
        public byte AlertsAddress { get; set; }
        public byte SubscribeOffers { get; set; }
        public byte SubscribeNews { get; set; }
        public string Usercode { get; set; }
        public DateTime ModifLastupdate { get; set; }
        public DateTime? TableDumped { get; set; }
    }
}
