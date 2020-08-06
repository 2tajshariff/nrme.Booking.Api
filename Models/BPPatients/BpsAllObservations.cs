using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsAllObservations
    {
        public int InternalId { get; set; }
        public int UserId { get; set; }
        public DateTime? ObservationDate { get; set; }
        public int Recordstatus { get; set; }
        public int Recordid { get; set; }
        public int ObservationTime { get; set; }
        public string ObservationName { get; set; }
        public int ObservationCode { get; set; }
        public string ObservationValue { get; set; }
        public int Description { get; set; }
        public string Provider { get; set; }
        public DateTime Created { get; set; }
    }
}
