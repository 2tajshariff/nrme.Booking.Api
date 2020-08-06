using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsVisits
    {
        public int InternalId { get; set; }
        public int VisitId { get; set; }
        public int UserId { get; set; }
        public int VisitCode { get; set; }
        public string VisitType { get; set; }
        public string Confidential { get; set; }
        public string DrName { get; set; }
        public DateTime? VisitDate { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int Duration { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string VisitNotes { get; set; }
        public DateTime Created { get; set; }
    }
}
