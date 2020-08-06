using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Acupunctureconditions
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Visitid { get; set; }
        public string Condition { get; set; }
        public int? Severity { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Acupuncturevisits Visit { get; set; }
    }
}
