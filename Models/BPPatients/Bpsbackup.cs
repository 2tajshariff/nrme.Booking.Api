using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Bpsbackup
    {
        public int Recordid { get; set; }
        public int Performbackup { get; set; }
        public int Backuptime { get; set; }
        public int Deleteold { get; set; }
        public int Sendmessage { get; set; }
        public string Backuppath { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
