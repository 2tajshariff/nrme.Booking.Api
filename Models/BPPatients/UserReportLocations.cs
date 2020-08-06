using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class UserReportLocations
    {
        public int ReportId { get; set; }
        public int UserId { get; set; }
        public int LocationId { get; set; }

        public virtual Locations Location { get; set; }
        public virtual Users User { get; set; }
    }
}
