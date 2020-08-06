using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsTobacco
    {
        public int InternalId { get; set; }
        public string SmokingStatus { get; set; }
        public string SmokingType { get; set; }
        public int SmokesPerDay { get; set; }
        public int YearStarted { get; set; }
        public string PastSmokingStatus { get; set; }
        public int PastSmokesPerDay { get; set; }
        public int PastStarted { get; set; }
        public int PastStopped { get; set; }
    }
}
