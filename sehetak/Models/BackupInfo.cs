using System;
using System.Collections.Generic;

namespace sehetak.Models
{
    public partial class BackupInfo
    {
        public DateTime BackupTime { get; set; }
        public DateTime BackupDate { get; set; }
        public string Usercode { get; set; }
        public string Backupresult { get; set; }
        public int Backuptime1 { get; set; }
    }
}
