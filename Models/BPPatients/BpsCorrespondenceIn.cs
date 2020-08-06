using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsCorrespondenceIn
    {
        public int InternalId { get; set; }
        public int DocumentId { get; set; }
        public int Stored { get; set; }
        public DateTime? CorrespondenceDate { get; set; }
        public string ContactName { get; set; }
        public string Category { get; set; }
        public string Subject { get; set; }
        public string Detail { get; set; }
        public string Comment { get; set; }
        public string Confidential { get; set; }
        public string UserReference { get; set; }
        public string Provider { get; set; }
        public DateTime Created { get; set; }
    }
}
