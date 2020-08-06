using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsAppointments
    {
        public string Patient { get; set; }
        public int InternalId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int AppointmentTime { get; set; }
        public int AppointmentLength { get; set; }
        public string Provider { get; set; }
        public string Urgent { get; set; }
        public string AppointmentType { get; set; }
        public string Status { get; set; }
        public int ArrivalTime { get; set; }
        public int ConsultationTime { get; set; }
        public string BookedBy { get; set; }
    }
}
