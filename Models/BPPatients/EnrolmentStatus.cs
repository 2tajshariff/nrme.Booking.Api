using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class EnrolmentStatus
    {
        public int RecordId { get; set; }
        public int RecordStatus { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
