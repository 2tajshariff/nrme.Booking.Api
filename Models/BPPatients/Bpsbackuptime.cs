using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Bpsbackuptime
    {
        public int Recordid { get; set; }
        public int Backupday { get; set; }
        public int Backuptime { get; set; }
        public int Compressed { get; set; }
        public string Backuppath { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
