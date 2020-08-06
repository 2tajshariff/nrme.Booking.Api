using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class PatientPresence
    {
        public int RecordId { get; set; }
        public int RecordStatus { get; set; }
        public int Presence { get; set; }
        public int AppointmentId { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Appointments Appointment { get; set; }
    }
}
