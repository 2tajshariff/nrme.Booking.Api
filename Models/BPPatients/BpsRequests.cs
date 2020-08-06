using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsRequests
    {
        public int InternalId { get; set; }
        public int RequestId { get; set; }
        public int RequestType { get; set; }
        public DateTime RequestDate { get; set; }
        public int RequestStatus { get; set; }
        public string ProviderName { get; set; }
        public string RequestedTests { get; set; }
        public string ClinicalDetails { get; set; }
        public string Copies { get; set; }
        public string Provider { get; set; }
        public DateTime Created { get; set; }
    }
}
