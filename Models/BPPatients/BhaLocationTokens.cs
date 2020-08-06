using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BhaLocationTokens
    {
        public int RecordId { get; set; }
        public int LocationId { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual Locations Location { get; set; }
    }
}
