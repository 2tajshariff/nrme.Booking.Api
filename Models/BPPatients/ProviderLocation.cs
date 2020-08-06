using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class ProviderLocation
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public int Locationid { get; set; }
        public string Providernumber { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public string Erxid { get; set; }
        public string Thumbprint { get; set; }

        public virtual Locations Location { get; set; }
        public virtual Users User { get; set; }
    }
}
