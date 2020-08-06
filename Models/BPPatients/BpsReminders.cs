using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsReminders
    {
        public int InternalId { get; set; }
        public int Reminderid { get; set; }
        public string ReasonText { get; set; }
        public DateTime ReminderDue { get; set; }
        public string Recurring { get; set; }
        public string Sent { get; set; }
        public string Provider { get; set; }
        public string Location { get; set; }
        public DateTime Created { get; set; }
    }
}
