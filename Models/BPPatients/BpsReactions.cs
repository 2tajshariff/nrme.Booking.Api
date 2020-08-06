using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsReactions
    {
        public int InternalId { get; set; }
        public string ItemName { get; set; }
        public string Reaction { get; set; }
        public string Severity { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
    }
}
