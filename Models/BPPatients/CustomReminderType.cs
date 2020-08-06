using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class CustomReminderType
    {
        public int ReminderTypeId { get; set; }
        public int RecordStatus { get; set; }
        public string Description { get; set; }
    }
}
