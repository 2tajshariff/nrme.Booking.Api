using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsParameters
    {
        public int InternalId { get; set; }
        public DateTime ObservationDate { get; set; }
        public int Recordid { get; set; }
        public string ObservationName { get; set; }
        public string ObservationValue { get; set; }
        public string Provider { get; set; }
        public DateTime Created { get; set; }
    }
}
