using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class SmsscheduleLocation
    {
        public int RecordId { get; set; }
        public int ScheduleId { get; set; }
        public int LocationId { get; set; }

        public virtual Locations Location { get; set; }
        public virtual Smsschedules Schedule { get; set; }
    }
}
