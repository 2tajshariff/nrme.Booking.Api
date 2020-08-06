using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsSessions
    {
        public string Day { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int Length { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Provider { get; set; }
    }
}
