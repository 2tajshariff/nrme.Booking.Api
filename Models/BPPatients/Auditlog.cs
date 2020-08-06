using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Auditlog
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public string Source { get; set; }
        public string Details { get; set; }
        public string Computer { get; set; }
        public DateTime Created { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
    }
}
