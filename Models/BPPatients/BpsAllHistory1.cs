using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsAllHistory1
    {
        public int InternalId { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Condition { get; set; }
        public int ConditionId { get; set; }
        public string Status { get; set; }
        public string Side { get; set; }
        public string Severity { get; set; }
        public string Acute { get; set; }
        public string Summary { get; set; }
        public string Fracture { get; set; }
        public string Displaced { get; set; }
        public string Compound { get; set; }
        public string Comminuted { get; set; }
        public string Spiral { get; set; }
        public string Greenstick { get; set; }
        public string Details { get; set; }
        public string Snomed { get; set; }
        public DateTime Created { get; set; }
    }
}
