using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsDiabetes
    {
        public int InternalId { get; set; }
        public int UserId { get; set; }
        public DateTime? DateRecorded { get; set; }
        public string DataName { get; set; }
        public string DiabetesValue { get; set; }
        public DateTime? DateValue { get; set; }
        public string Provider { get; set; }
    }
}
