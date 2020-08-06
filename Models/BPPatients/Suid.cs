using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Suid
    {
        public int Internalid { get; set; }
        public int Recordstatus { get; set; }
        public string Suid1 { get; set; }
        public int Richrecord { get; set; }

        public virtual Patients Internal { get; set; }
    }
}
