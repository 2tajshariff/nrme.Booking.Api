using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Healthlinksession
    {
        public string Sessionkey { get; set; }
        public int? Internalid { get; set; }
        public int? Userid { get; set; }
        public int? Visitid { get; set; }
        public int? Locationid { get; set; }
        public DateTime Created { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Locations Location { get; set; }
        public virtual Users User { get; set; }
        public virtual Visits Visit { get; set; }
    }
}
