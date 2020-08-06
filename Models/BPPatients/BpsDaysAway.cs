using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsDaysAway
    {
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string Reason { get; set; }
        public string Provider { get; set; }
    }
}
