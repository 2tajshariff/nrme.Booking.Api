using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class NesnotificationParameters
    {
        public int RecordId { get; set; }
        public int NotificationId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual Nesnotifications Notification { get; set; }
    }
}
