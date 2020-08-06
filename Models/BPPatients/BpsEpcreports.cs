using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsEpcreports
    {
        public int ReportId { get; set; }
        public int InternalId { get; set; }
        public DateTime ReportDate { get; set; }
        public string ReportType { get; set; }
        public int Stored { get; set; }
        public string Finalised { get; set; }
        public string Provider { get; set; }
        public DateTime Created { get; set; }
    }
}
