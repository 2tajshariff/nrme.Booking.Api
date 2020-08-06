using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Argussetup
    {
        public int Recordid { get; set; }
        public string Servername { get; set; }
        public int? Port { get; set; }
        public string Argususer { get; set; }
        public string Arguspw { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
