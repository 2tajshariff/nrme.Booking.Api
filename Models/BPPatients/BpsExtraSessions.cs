using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsExtraSessions
    {
        public DateTime SessionDate { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int Length { get; set; }
        public string Provider { get; set; }
    }
}
