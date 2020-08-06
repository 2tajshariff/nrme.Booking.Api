using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsVisitReason
    {
        public int InternalId { get; set; }
        public int VisitId { get; set; }
        public string Provider { get; set; }
        public DateTime? VisitDate { get; set; }
        public string Reason { get; set; }
    }
}
